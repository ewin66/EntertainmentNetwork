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

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseModelService;
import isd.dp.ua.EntertainmentNetworkServer.Dao.*;
import isd.dp.ua.EntertainmentNetworkServer.Interfaces.ISchedulerService;
import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService(serviceName="SchedulerWebService", endpointInterface="isd.dp.ua.EntertainmentNetworkServer.Interfaces.ISchedulerService")
@Service
public class SchedulerService extends BaseModelService implements ISchedulerService
{
	@Autowired
	public SchedulerService(ShowDao showOperations, HallDao hallOperations, SchedulerDao schedulerOperations, ModelMapper modelMapper)
	{
		super(modelMapper);
		this.schedulerOperations = schedulerOperations;
		this.showOperations = showOperations;
		this.hallOperations = hallOperations;
	}

	@Override
	public void addScheduler(AddSchedulerRequest  addRequest) 
	{
		this.schedulerOperations.persist(this.prepareScheduler(addRequest));
	}

	@Override
	public Scheduler findSchedulerById(BigDecimal id) 
	{
		return this.schedulerOperations.findById(id);
	}

	@Override
	public List<Scheduler> getSchedulers() 
	{
		List<Scheduler> test = this.schedulerOperations.getAll();
		return test;
	}

	@Override
	public Scheduler mergeScheduler(MergeSchedulerRequest mergeRequest)
	{
		return this.schedulerOperations.merge(this.prepareScheduler(mergeRequest));
	}

	@Override
	public void removeScheduler(BigDecimal id)
	{
		Scheduler scheduler = new Scheduler();
		scheduler.setSchId(id);
		this.schedulerOperations.remove(scheduler);
	}
	
	/*
	 * Prepares cinema: find city, add it to cinema entity
	 */
	protected Scheduler prepareScheduler(AddSchedulerRequest request)
	{
		Hall hall = this.hallOperations.findById(request.getHalId());
		Show show = this.showOperations.findById(request.getShwId());
		Scheduler scheduler = this.convertToEntity(request, Scheduler.class);
		scheduler.setHall(hall);
		scheduler.setShow(show);
		return scheduler;
	}
	
	protected SchedulerDao schedulerOperations;
	protected ShowDao showOperations;
	protected HallDao hallOperations;
}
