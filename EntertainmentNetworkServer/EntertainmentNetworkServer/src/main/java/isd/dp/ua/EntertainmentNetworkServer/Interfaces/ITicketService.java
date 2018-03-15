package isd.dp.ua.EntertainmentNetworkServer.Interfaces;

import java.math.BigDecimal;
import java.util.List;

import javax.jws.WebService;

import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService
public interface ITicketService 
{
	void addTicket(AddTicketRequest show);

	Tickets findTicketById(BigDecimal id);
	
	List<Tickets> getTickets();
	
	Tickets mergeTicket(MergeTicketRequest show);
	
	void removeTicket(BigDecimal id);
}
