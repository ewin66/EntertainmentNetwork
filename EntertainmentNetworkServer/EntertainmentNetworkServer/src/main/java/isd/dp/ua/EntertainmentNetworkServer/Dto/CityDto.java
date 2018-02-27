package isd.dp.ua.EntertainmentNetworkServer.Dto;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;

import javax.xml.bind.annotation.*;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlType
public class CityDto  extends BaseDto 
{
	public BigDecimal getCitId()
	{
		return this.citId;
	}

	public void setCitId(BigDecimal citId)
	{
		this.citId = citId;
	}

	public String getCitName()
	{
		return this.citName;
	}

	public void setCitName(String citName)
	{
		this.citName = citName;
	}

	public String getCitCountry()
	{
		return this.citCountry;
	}

	public void setCitCountry(String citCountry)
	{
		this.citCountry = citCountry;
	}
	
	public List<CinemaDto> getCinemas()
	{
		return this.cinemas;
	}

	public void setCinemas(List<CinemaDto> cinemas)
	{
		this.cinemas = cinemas;
	}
	
	private BigDecimal citId;
	private String citName;
	private String citCountry;
    private List<CinemaDto> cinemas = new ArrayList<CinemaDto>();
}
