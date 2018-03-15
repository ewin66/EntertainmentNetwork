package isd.dp.ua.EntertainmentNetworkServer.Interfaces;

import java.math.BigDecimal;
import java.util.List;

import javax.jws.WebService;

import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService
public interface IFloorService 
{
	void addFloor(AddFloorRequest transientInstance);

	Floor findFloorById(BigDecimal id);
	
	public List<Floor> getFloors();
	
	Floor mergeFloor(MergeFloorRequest detachedInstance);
	
	void removeFloor(BigDecimal id);
}
