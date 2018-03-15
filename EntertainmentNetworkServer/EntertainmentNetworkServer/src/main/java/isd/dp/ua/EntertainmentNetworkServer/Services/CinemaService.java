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
import isd.dp.ua.EntertainmentNetworkServer.Interfaces.ICinemaService;
import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService(serviceName="CinemaWebService", endpointInterface="isd.dp.ua.EntertainmentNetworkServer.Interfaces.ICinemaService")
@Service
public class CinemaService extends BaseModelService implements ICinemaService
{
	@Autowired
	public CinemaService(CinemaDao cinemaOperations, CityDao cityOperations, ModelMapper modelMapper)
	{
		super(modelMapper);
		this.cityOperations = cityOperations;
		this.cinemaOperations = cinemaOperations;
	}

	@Override
	public void addCinema(AddCinemaRequest addRequest) 
	{
		this.cinemaOperations.persist(this.prepareCinema(addRequest));
	}

	@Override
	public Cinema findCinemaById(BigDecimal id) 
	{
		return this.cinemaOperations.findById(id);
	}

	public List<Cinema> findCinemaByAddress(String address)
	{
		return this.cinemaOperations.findCinemaByAddress(address);
	}
	
	public List<Cinema> findCinemaByName(String name) 
	{
		return this.cinemaOperations.findCinemaByName(name);
	}

	@Override
	public List<Cinema> getCinemas() 
	{
		return this.cinemaOperations.getAll();
	}

	@Override
	public Cinema mergeCinema(MergeCinemaRequest mergeRequest)
	{
		return this.cinemaOperations.merge(this.prepareCinema(mergeRequest));
	}

	@Override
	public void removeCinema(BigDecimal id)
	{
		Cinema cinema = new Cinema();
		cinema.setCinId(id);
		this.cinemaOperations.remove(cinema);
	}
	
	/*
	 * Prepares cinema: find city, add it to cinema entity
	 */
	protected Cinema prepareCinema(AddCinemaRequest request)
	{
		City city = this.cityOperations.findById(request.getCitId());
		Cinema cinema = this.convertToEntity(request, Cinema.class);
		cinema.setCity(city);
		return cinema;
	}
	
	protected CityDao cityOperations;
	protected CinemaDao cinemaOperations;
}
