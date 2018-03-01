package isd.dp.ua.EntertainmentNetworkServer.Interfaces;

import java.math.BigDecimal;
import java.util.List;

import javax.jws.*;

import isd.dp.ua.EntertainmentNetworkServer.Models.City;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService
public interface ICityService
{
	void addCity(AddCityRequest transientInstance);

	void removeCity(BigDecimal id);

	City mergeCity(MergeCityRequest detachedInstance);

	City findCityById(BigDecimal id);
	
	List<City> findByName(String name);
	
	List<City> getCities();
}
