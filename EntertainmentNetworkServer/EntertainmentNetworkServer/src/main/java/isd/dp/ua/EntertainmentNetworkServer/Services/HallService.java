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
import java.util.List;

import javax.jws.WebService;

import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Service;

import isd.dp.ua.EntertainmentNetworkServer.Common.*;
import isd.dp.ua.EntertainmentNetworkServer.Dao.CinemaDao;
import isd.dp.ua.EntertainmentNetworkServer.Dao.HallDao;
import isd.dp.ua.EntertainmentNetworkServer.Interfaces.IHallService;
import isd.dp.ua.EntertainmentNetworkServer.Models.Cinema;
import isd.dp.ua.EntertainmentNetworkServer.Models.Hall;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService(endpointInterface="isd.dp.ua.EntertainmentNetworkServer.Interfaces.IHallService")
@Service
public class HallService extends BaseModelService implements IHallService
{
	@Autowired
	public HallService(@Qualifier("hallDao") HallDao hallOperations, CinemaDao cinemaOperations, ModelMapper modelMapper)
	{
		super(modelMapper);
		this.hallOperations = hallOperations;
		this.cinemaOperations = cinemaOperations;
	}

	@Override
	public void addHall(AddHallRequest addRequest) 
	{
		this.hallOperations.persist(this.prepareHall(addRequest));
	}

	@Override
	public Hall findHallById(BigDecimal id) 
	{
		return this.hallOperations.findById(id);
	}

	@Override
	public List<Hall> getHalls() 
	{
		return this.hallOperations.getAll();
	}

	@Override
	public Hall mergeHall(MergeHallRequest mergeRequest) 
	{
		return this.hallOperations.merge(this.prepareHall(mergeRequest));
	}

	@Override
	public void removeHall(BigDecimal halId) 
	{
		Hall hall = new Hall();
		hall.setHalId(halId);
		this.hallOperations.remove(hall);
	}
	
	/*
	 * Prepares hall: find cinema add it to hall entity
	 */
	protected Hall prepareHall(AddHallRequest request)
	{		
		Cinema cinema = this.cinemaOperations.findById(request.getCinId());
		Hall hall = this.convertToEntity(request, Hall.class);
		hall.setCinema(cinema);
		return hall;
	}
	
	private CinemaDao cinemaOperations;	
	private HallDao hallOperations;
}
