package isd.dp.ua.EntertainmentNetworkServer.Interfaces;

import java.math.BigDecimal;
import java.util.List;

import javax.jws.WebService;

import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService
public interface ISeatService 
{
	void addSeat(AddSeatRequest seat);

	Seat findSeatById(BigDecimal id);
	
	void generateSeats(GenerateSeatRequest generateRequest);
	
	List<Seat> getSeats();
	
	Seat mergeSeat(MergeSeatRequest seat);
	
	void removeSeat(BigDecimal id);
}
