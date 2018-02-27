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
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Service;

import isd.dp.ua.EntertainmentNetworkServer.Common.*;
import isd.dp.ua.EntertainmentNetworkServer.Dao.*;
import isd.dp.ua.EntertainmentNetworkServer.Dto.*;
import isd.dp.ua.EntertainmentNetworkServer.Interfaces.ICityService;
import isd.dp.ua.EntertainmentNetworkServer.Models.*;

@WebService(serviceName="CityWebService", endpointInterface="isd.dp.ua.EntertainmentNetworkServer.Interfaces.ICityService")
@Service
public class CityService extends BaseModelService<CityDao, City, CityDto> implements ICityService
{	
	@Autowired
	public CityService(@Qualifier("cityDao")CityDao daoOperations, ModelMapper modelMapper)
	{
		super(daoOperations, City.class, CityDto.class, modelMapper);
	}

	@Override
	public void addCity(CityDto dto) 
	{		
		this.persist(dto);
	}

	@Override
	public List<CityDto> getCities() 
	{	
		return super.getAll();
	}
	
	public CityDto findCityById(BigDecimal id) 
	{
		return super.findById(id);
	} 	

	@Override
	public List<CityDto> findByName(String name) 
	{
		List<CityDto> dtos = new ArrayList<CityDto>();
		for(City entity : this.daoOperations.findByName(name))
		{
			dtos.add(super.convertToDto(entity, this.getModel()));
		}
		
		return dtos;
	}
	
	@Override
	public void removeCity(CityDto dto) 
	{
		this.remove(dto);		
	}

	@Override
	public CityDto mergeCity(CityDto dto)
	{
		return this.merge(dto);
	}	
}
