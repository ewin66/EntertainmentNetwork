/* 
* This module is part of the Entertainment Network system 
* Copyright (c) SCC Soft Computer, Inc. 2018 
* All Rights Reserved 
* 
* This document contains unpublished, confidential and proprietary 
* information of SCC Soft Computer, Inc. No disclosure or use of 
* any portion of the contents of these materials may be made without the 
* express written consent of Soft Computer Consultants, Inc. 
* 
*/ 

package isd.dp.ua.EntertainmentNetworkServer.Services;


import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;

import javax.jws.WebService;

import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import isd.dp.ua.EntertainmentNetworkServer.Common.*;
import isd.dp.ua.EntertainmentNetworkServer.Dao.*;
import isd.dp.ua.EntertainmentNetworkServer.Interfaces.ISeatService;
import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService(serviceName="SitsWebService", endpointInterface="isd.dp.ua.EntertainmentNetworkServer.Interfaces.ISeatService")
@Service
public class SeatService extends BaseModelService implements ISeatService
{
	@Autowired
	public SeatService(SeatDao seatOperations, FloorDao floorOperations, ModelMapper modelMapper)
	{
		super(modelMapper);
		this.seatOperations = seatOperations;
		this.floorOperations = floorOperations;
	}

	@Override
	public void addSeat(AddSeatRequest addRequest) 
	{	
		Seat sit = this.prepareSeat(addRequest);
		sit.setSeatId(null); // TODO: problem: modelmapper converts halId to sitId
		this.seatOperations.persist(sit);
	}

	@Override
	public Seat findSeatById(BigDecimal id) 
	{
		return this.seatOperations.findById(id);
	}
	
	@Override
	public void generateSeats(GenerateSeatRequest generateRequest) 
	{	
		List<Seat> seats = new ArrayList<Seat>();
		Floor floor = this.floorOperations.findById(generateRequest.getFlrId());
		if(floor != null)
		{
			int seatNum = 1;
			for(int row = 0; row < generateRequest.getSeatRows(); row++)
			{
				for(int column = 0; column < generateRequest.getSeatColumns(); column++)
				{
					Seat seat = new Seat();
					seat.setFloor(floor);
					seat.setSeatNum(seatNum++);
					seat.setSeatRow(row);
					seat.setSeatColumn(column);
					seat.setSeatType(0);
					seat.setSeatIsactive(true);
					seats.add(seat);
		        }
	        }
			
			this.seatOperations.addSeats(seats);
		}
	}	
	
	@Override
	public List<Seat> getSeats() 
	{	
		return this.seatOperations.getAll();
	}

	@Override
	public Seat mergeSeat(MergeSeatRequest mergeRequest)
	{		
		return this.seatOperations.merge(this.prepareSeat(mergeRequest));
	}

	@Override
	public void removeSeat(BigDecimal id) 
	{
		Seat sit = new Seat();
		sit.setSeatId(id);
		this.seatOperations.remove(sit);			
	}	
		
	/*
	 * Prepares sit: find hall, add it to sit entity
	 */
	protected Seat prepareSeat(AddSeatRequest request)
	{
		Floor floor = this.floorOperations.findById(request.getFlrId());
		Seat sit = this.convertToEntity(request, Seat.class);
		sit.setFloor(floor);
		return sit;
	}
	
	protected SeatDao seatOperations;
	protected FloorDao floorOperations;
}
