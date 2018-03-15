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
import isd.dp.ua.EntertainmentNetworkServer.Interfaces.ITicketService;
import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService(serviceName="TicketWebService", endpointInterface="isd.dp.ua.EntertainmentNetworkServer.Interfaces.ITicketService")
@Service
public class TicketService extends BaseModelService implements ITicketService
{
	@Autowired
	public TicketService(SeatDao seatOperations, OrderDao orderOperations, SchedulerDao schedulerOperations, TicketDao ticketsOperations, ModelMapper modelMapper)
	{
		super(modelMapper);
		this.seatOperations = seatOperations;
		this.orderOperations = orderOperations;
		this.schedulerOperations = schedulerOperations;
		this.ticketsOperations = ticketsOperations;
	}

	@Override
	public void addTicket(AddTicketRequest  addRequest) 
	{
		this.ticketsOperations.persist(this.prepareTicket(addRequest));
	}

	@Override
	public Tickets findTicketById(BigDecimal id) 
	{
		return this.ticketsOperations.findById(id);
	}

	@Override
	public List<Tickets> getTickets() 
	{
		return this.ticketsOperations.getAll();
	}

	@Override
	public Tickets mergeTicket(MergeTicketRequest mergeRequest)
	{
		return this.ticketsOperations.merge(this.prepareTicket(mergeRequest));
	}

	@Override
	public void removeTicket(BigDecimal id)
	{
		Tickets ticket = new Tickets();
		ticket.setTctId(id);
		this.ticketsOperations.remove(ticket);
	}
	
	/*
	 * Prepares cinema: find city, add it to cinema entity
	 */
	protected Tickets prepareTicket(AddTicketRequest request)
	{
		Seat seat = this.seatOperations.findById(request.getSeatId());
		Scheduler scheduler = this.schedulerOperations.findById(request.getSchId());
		Orders order = this.orderOperations.findById(request.getOrdId());		
		Tickets tickets = this.convertToEntity(request, Tickets.class);
		tickets.setSeat(seat);
		tickets.setScheduler(scheduler);
		tickets.setOrders(order);		
		return tickets;
	}
	
	protected TicketDao ticketsOperations;
	protected SeatDao seatOperations;
	protected OrderDao orderOperations;
	protected SchedulerDao schedulerOperations;
}
