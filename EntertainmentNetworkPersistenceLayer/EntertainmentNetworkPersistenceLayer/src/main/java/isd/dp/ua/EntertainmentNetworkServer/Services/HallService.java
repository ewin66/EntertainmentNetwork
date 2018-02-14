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
import isd.dp.ua.EntertainmentNetworkServer.Dao.HallDao;
import isd.dp.ua.EntertainmentNetworkServer.Models.Hall;

@Service
public class HallService extends BaseModelService<Hall>
{
	@Autowired
	protected HallService(HallDao daoOperations)
	{
		super(daoOperations);
	}   
}
