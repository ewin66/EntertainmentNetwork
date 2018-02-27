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


import javax.jws.WebService;

import org.modelmapper.ModelMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Service;

import isd.dp.ua.EntertainmentNetworkServer.Common.*;
import isd.dp.ua.EntertainmentNetworkServer.Dao.SitDao;
import isd.dp.ua.EntertainmentNetworkServer.Dto.SitDto;
import isd.dp.ua.EntertainmentNetworkServer.Models.Sit;

@WebService(endpointInterface="isd.dp.ua.EntertainmentNetworkServer.Common.ICrudOperations")
@Service
public class SitService extends BaseModelService<SitDao, Sit, SitDto>
{
	@Autowired
	public SitService(@Qualifier("sitDao") SitDao daoOperations, ModelMapper modelMapper)
	{
		super(daoOperations, Sit.class, SitDto.class, modelMapper);
	}   
}
