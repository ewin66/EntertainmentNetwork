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
import isd.dp.ua.EntertainmentNetworkServer.Interfaces.IOrderService;
import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService(serviceName="OrderWebService", endpointInterface="isd.dp.ua.EntertainmentNetworkServer.Interfaces.IOrderService")
@Service
public class OrderService extends BaseModelService implements IOrderService
{
	@Autowired
	public OrderService(OrderDao orderOperations, ModelMapper modelMapper)
	{
		super(modelMapper);
		this.orderOperations = orderOperations;
	}

	@Override
	public void addOrder(AddOrderRequest addRequest) 
	{
		this.orderOperations.persist(this.prepareOrder(addRequest));
	}

	@Override
	public Orders findOrderById(BigDecimal id) 
	{
		return this.orderOperations.findById(id);
	}

	@Override
	public List<Orders> getOrders() 
	{
		return this.orderOperations.getAll();
	}

	@Override
	public Orders mergeOrder(MergeOrderRequest mergeRequest)
	{
		return this.orderOperations.merge(this.prepareOrder(mergeRequest));
	}

	@Override
	public void removeOrder(BigDecimal id)
	{
		Orders order = new Orders();
		order.setOrdId(id);
		this.orderOperations.remove(order);
	}
	
	/*
	 * Prepares cinema: find city, add it to cinema entity
	 */
	protected Orders prepareOrder(AddOrderRequest request)
	{
		Orders order = this.convertToEntity(request, Orders.class);
		return order;
	}
	
	protected OrderDao orderOperations;
}
