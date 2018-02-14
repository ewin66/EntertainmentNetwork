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


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseModelService;
import isd.dp.ua.EntertainmentNetworkServer.Dao.CinemaDao;
import isd.dp.ua.EntertainmentNetworkServer.Models.Cinema;

@Service
public class CinemaService extends BaseModelService<Cinema>
{
	@Autowired
	protected CinemaService(CinemaDao daoOperations)
	{
		super(daoOperations);
	}   
}
