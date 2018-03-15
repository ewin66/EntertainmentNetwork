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
import isd.dp.ua.EntertainmentNetworkServer.Interfaces.IShowService;
import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService(serviceName="ShowWebService", endpointInterface="isd.dp.ua.EntertainmentNetworkServer.Interfaces.IShowService")
@Service
public class ShowService extends BaseModelService implements IShowService
{
	@Autowired
	public ShowService(ShowDao showOperations, ModelMapper modelMapper)
	{
		super(modelMapper);
		this.showOperations = showOperations;
	}

	@Override
	public void addShow(AddShowRequest  addRequest) 
	{
		this.showOperations.persist(this.prepareShow(addRequest));
	}

	@Override
	public Show findShowById(BigDecimal id) 
	{
		return this.showOperations.findById(id);
	}

	@Override
	public List<Show> getShows() 
	{
		return this.showOperations.getAll();
	}

	@Override
	public Show mergeShow(MergeShowRequest mergeRequest)
	{
		return this.showOperations.merge(this.prepareShow(mergeRequest));
	}

	@Override
	public void removeShow(BigDecimal id)
	{
		Show show = new Show();
		show.setShwId(id);
		this.showOperations.remove(show);
	}
	
	/*
	 * Prepares cinema: find city, add it to cinema entity
	 */
	protected Show prepareShow(AddShowRequest request)
	{
		return this.convertToEntity(request, Show.class);
	}
	
	protected ShowDao showOperations;
}
