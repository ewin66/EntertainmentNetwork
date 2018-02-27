package isd.dp.ua.EntertainmentNetworkServer.Interfaces;

import java.math.BigDecimal;
import java.util.List;

import javax.jws.*;

import isd.dp.ua.EntertainmentNetworkServer.Dto.CityDto;

@WebService
public interface ICityService
{
	void addCity(CityDto transientInstance);

	void removeCity(CityDto persistentInstance);

	CityDto mergeCity(CityDto detachedInstance);

	CityDto findCityById(BigDecimal id);
	
	List<CityDto> findByName(String name);
	
	List<CityDto> getCities();
}
