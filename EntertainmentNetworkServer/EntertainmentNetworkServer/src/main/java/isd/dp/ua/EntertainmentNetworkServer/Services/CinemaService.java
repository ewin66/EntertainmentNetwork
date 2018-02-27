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

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseModelService;
import isd.dp.ua.EntertainmentNetworkServer.Dao.CinemaDao;
import isd.dp.ua.EntertainmentNetworkServer.Dto.CinemaDto;
import isd.dp.ua.EntertainmentNetworkServer.Interfaces.ICinemaService;
import isd.dp.ua.EntertainmentNetworkServer.Models.Cinema;

@WebService(serviceName="CinemaWebService", endpointInterface="isd.dp.ua.EntertainmentNetworkServer.Interfaces.ICinemaService")
@Service
public class CinemaService extends BaseModelService<CinemaDao, Cinema, CinemaDto> implements ICinemaService
{
	@Autowired
	public CinemaService(@Qualifier("cinemaDao") CinemaDao daoOperations, ModelMapper modelMapper)
	{
		super(daoOperations, Cinema.class, CinemaDto.class, modelMapper);
	}

	@Override
	public void addCinema(CinemaDto dto) 
	{		
		this.persist(dto);
	}

	@Override
	public CinemaDto findCinemaById(BigDecimal id) 
	{
		return super.findById(id);
	}

	public List<CinemaDto> findCinemaByAddress(String address)
	{
		List<CinemaDto> dtos = new ArrayList<CinemaDto>();
		for(Cinema entity : super.daoOperations.findCinemaByAddress(address))
		{
			dtos.add(super.convertToDto(entity, this.getModel()));
		}
		
		return dtos;
	}
	
	public List<CinemaDto> findCinemaByName(String name) 
	{
		List<CinemaDto> dtos = new ArrayList<CinemaDto>();
		for(Cinema entity : super.daoOperations.findCinemaByName(name))
		{
			dtos.add(super.convertToDto(entity, this.getModel()));
		}
		
		return dtos;
	}

	@Override
	public List<CinemaDto> getCinemas() 
	{
		return super.getAll();
	}

	@Override
	public CinemaDto mergeCinema(CinemaDto dto)
	{
		return this.merge(dto);
	}

	@Override
	public void removeCinema(CinemaDto dto)
	{		
		this.remove(dto);
	}
}
