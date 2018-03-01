package isd.dp.ua.EntertainmentNetworkServer.Interfaces;

import java.math.BigDecimal;
import java.util.List;

import javax.jws.WebService;

import isd.dp.ua.EntertainmentNetworkServer.Models.Cinema;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService
public interface ICinemaService 
{
	public void addCinema(AddCinemaRequest dto);
	
	public Cinema findCinemaById(BigDecimal id);

	public List<Cinema> findCinemaByName(String name);
	
	public List<Cinema> getCinemas();
	
	public Cinema mergeCinema(MergeCinemaRequest dto);
	
	public void removeCinema(BigDecimal id);
}
