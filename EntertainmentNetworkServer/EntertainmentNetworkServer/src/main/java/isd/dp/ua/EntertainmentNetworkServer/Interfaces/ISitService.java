package isd.dp.ua.EntertainmentNetworkServer.Interfaces;

import java.math.BigDecimal;
import java.util.List;

import javax.jws.WebService;

import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService
public interface ISitService 
{
	void addSit(AddSitRequest transientInstance);

	Sit findSitById(BigDecimal id);
	
	public List<Sit> getSits();
	
	Sit mergeSit(MergeSitRequest detachedInstance);
	
	void removeSit(BigDecimal id);
}
