package isd.dp.ua.EntertainmentNetworkServer.Interfaces;

import java.math.BigDecimal;
import java.util.List;

import javax.jws.WebService;

import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService
public interface IShowService 
{
	void addShow(AddShowRequest show);

	Show findShowById(BigDecimal id);
	
	List<Show> getShows();
	
	Show mergeShow(MergeShowRequest show);
	
	void removeShow(BigDecimal id);
}
