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
import org.springframework.stereotype.Service;

import isd.dp.ua.EntertainmentNetworkServer.Common.*;
import isd.dp.ua.EntertainmentNetworkServer.Dao.*;
import isd.dp.ua.EntertainmentNetworkServer.Interfaces.IFloorService;
import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService(serviceName="FloorWebService", endpointInterface="isd.dp.ua.EntertainmentNetworkServer.Interfaces.IFloorService")
@Service
public class FloorService extends BaseModelService implements IFloorService
{
	@Autowired
	public FloorService(FloorDao floorOperations, HallDao hallOperations, ModelMapper modelMapper)
	{
		super(modelMapper);
		this.hallOperations = hallOperations;
		this.floorOperations = floorOperations;
	}

	@Override
	public void addFloor(AddFloorRequest addRequest) 
	{
		this.floorOperations.persist(this.prepareFloor(addRequest));
	}

	@Override
	public Floor findFloorById(BigDecimal id) 
	{
		return this.floorOperations.findById(id);
	}

	@Override
	public List<Floor> getFloors() 
	{
		return this.floorOperations.getAll();
	}

	@Override
	public Floor mergeFloor(MergeFloorRequest mergeRequest) 
	{
		return this.floorOperations.merge(this.prepareFloor(mergeRequest));
	}

	@Override
	public void removeFloor(BigDecimal flrId) 
	{
		Floor floor = new Floor();
		floor.setFlrId(flrId);
		this.floorOperations.remove(floor);
	}
	
	/*
	 * Prepares hall: find cinema add it to hall entity
	 */
	protected Floor prepareFloor(AddFloorRequest request)
	{		
		Hall hall = this.hallOperations.findById(request.getHalId());
		Floor floor = this.convertToEntity(request, Floor.class);
		floor.setHall(hall);
		return floor;
	}
	
	private FloorDao floorOperations;	
	private HallDao hallOperations;
}
