package isd.dp.ua.EntertainmentNetworkServer.Interfaces;

import java.math.BigDecimal;
import java.util.List;

import javax.jws.WebService;

import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService
public interface IHallService 
{
	void addHall(AddHallRequest transientInstance);

	Hall findHallById(BigDecimal id);
	
	public List<Hall> getHalls();
	
	Hall mergeHall(MergeHallRequest detachedInstance);
	
	void removeHall(BigDecimal id);
}
