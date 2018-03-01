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
import isd.dp.ua.EntertainmentNetworkServer.Dao.HallDao;
import isd.dp.ua.EntertainmentNetworkServer.Dao.SitDao;
import isd.dp.ua.EntertainmentNetworkServer.Interfaces.ISitService;
import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService(serviceName="SitsWebService", endpointInterface="isd.dp.ua.EntertainmentNetworkServer.Interfaces.ISitService")
@Service
public class SitService extends BaseModelService implements ISitService
{
	@Autowired
	public SitService(@Qualifier("sitDao") SitDao sitOperations, HallDao hallOperations, ModelMapper modelMapper)
	{
		super(modelMapper);
		this.sitOperations = sitOperations;
		this.hallOperations = hallOperations;
	}

	@Override
	public void addSit(AddSitRequest addRequest) 
	{	
		Sit sit = this.prepareSit(addRequest);
		sit.setSitId(null); // TODO: problem: modelmapper converts halId to sitId
		this.sitOperations.persist(sit);
	}

	@Override
	public Sit findSitById(BigDecimal id) 
	{
		return this.sitOperations.findById(id);
	}
	
	@Override
	public List<Sit> getSits() 
	{	
		return this.sitOperations.getAll();
	}

	@Override
	public Sit mergeSit(MergeSitRequest mergeRequest)
	{		
		return this.sitOperations.merge(this.prepareSit(mergeRequest));
	}

	@Override
	public void removeSit(BigDecimal id) 
	{
		Sit sit = new Sit();
		sit.setSitId(id);
		this.sitOperations.remove(sit);			
	}	
		
	/*
	 * Prepares sit: find hall, add it to sit entity
	 */
	protected Sit prepareSit(AddSitRequest request)
	{
		Hall hall = this.hallOperations.findById(request.getHalId());
		Sit sit = this.convertToEntity(request, Sit.class);
		sit.setHall(hall);
		return sit;
	}
	
	protected SitDao sitOperations;
	protected HallDao hallOperations;
}
