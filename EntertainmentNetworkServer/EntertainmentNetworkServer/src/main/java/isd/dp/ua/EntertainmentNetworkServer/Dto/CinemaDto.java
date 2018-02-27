package isd.dp.ua.EntertainmentNetworkServer.Dto;

import java.math.BigDecimal;
import java.sql.Blob;
import java.util.ArrayList;
import java.util.List;

import javax.xml.bind.annotation.*;
import javax.xml.bind.annotation.adapters.XmlJavaTypeAdapter;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlType
public class CinemaDto extends BaseDto 
{	
	public BigDecimal getCinId()
	{
		return this.cinId;
	}

	public void setCinId(BigDecimal cinId)
	{
		this.cinId = cinId;
	}

	public CityDto getCity()
	{
		return this.city;
	}

	public void setCity(CityDto city)
	{
		this.city = city;
	}

	public String getCinName()
	{
		return this.cinName;
	}

	public void setCinName(String cinName)
	{
		this.cinName = cinName;
	}

	public Blob getCinIcon()
	{
		return this.cinIcon;
	}

	public void setCinIcon(Blob cinIcon)
	{
		this.cinIcon = cinIcon;
	}

	public String getCinAddress()
	{
		return this.cinAddress;
	}

	public void setCinAddress(String cinAddress)
	{
		this.cinAddress = cinAddress;
	}

	public List<HallDto> getHalls()
	{
		return this.halls;
	}

	public void setHalls(List<HallDto> halls)
	{
		this.halls = halls;
	}

	private BigDecimal cinId;
	@XmlTransient
	private CityDto city;
	private String cinName;
	@XmlJavaTypeAdapter(BlobXmlAdapter.class)
	private Blob cinIcon;
	private String cinAddress;
	private List<HallDto> halls = new ArrayList<HallDto>();
}
