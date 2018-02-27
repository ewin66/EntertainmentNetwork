package isd.dp.ua.EntertainmentNetworkServer.Interfaces;

import java.math.BigDecimal;
import java.util.List;

import javax.jws.WebService;

import isd.dp.ua.EntertainmentNetworkServer.Dto.CinemaDto;

@WebService
public interface ICinemaService 
{
	public void addCinema(CinemaDto dto);
	
	public CinemaDto findCinemaById(BigDecimal id);

	public List<CinemaDto> findCinemaByName(String name);
	
	public List<CinemaDto> getCinemas();
	
	public CinemaDto mergeCinema(CinemaDto dto);
	
	public void removeCinema(CinemaDto dto);
}
