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
import isd.dp.ua.EntertainmentNetworkServer.Dao.*;
import isd.dp.ua.EntertainmentNetworkServer.Interfaces.ICityService;
import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService(serviceName="CityWebService", endpointInterface="isd.dp.ua.EntertainmentNetworkServer.Interfaces.ICityService")
@Service
public class CityService extends BaseModelService implements ICityService
{	
	@Autowired
	public CityService(@Qualifier("cityDao")CityDao cityOperations, ModelMapper modelMapper)
	{
		super(modelMapper);
		this.cityOperations = cityOperations;
	}

	@Override
	public void addCity(AddCityRequest addRequest) 
	{	
		City city = this.convertToEntity(addRequest, City.class);
		this.cityOperations.persist(city);
	}

	@Override
	public List<City> getCities() 
	{	
		return this.cityOperations.getAll();
	}
	
	public City findCityById(BigDecimal id) 
	{
		return this.cityOperations.findById(id);
	} 	

	@Override
	public List<City> findByName(String name) 
	{
		return this.cityOperations.findByName(name);
	}
	
	@Override
	public void removeCity(BigDecimal id) 
	{
		City city = new City();
		city.setCitId(id);
		this.cityOperations.remove(city);		
	}

	@Override
	public City mergeCity(MergeCityRequest mergeRequest)
	{
		City city = this.convertToEntity(mergeRequest, City.class);
		return this.cityOperations.merge(city);
	}	
	
	protected CityDao cityOperations;
}
