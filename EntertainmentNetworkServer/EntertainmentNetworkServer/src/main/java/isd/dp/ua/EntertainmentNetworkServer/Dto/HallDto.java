package isd.dp.ua.EntertainmentNetworkServer.Dto;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.annotation.*;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlType
public class HallDto  extends BaseDto 
{
	public BigDecimal getHalId()
	{
		return this.halId;
	}

	public void setHalId(BigDecimal halId)
	{
		this.halId = halId;
	}

	public CinemaDto getCinema()
	{
		return this.cinema;
	}

	public void setCinema(CinemaDto cinema)
	{
		this.cinema = cinema;
	}

	public String getHalName()
	{
		return this.halName;
	}

	public void setHalName(String halName)
	{
		this.halName = halName;
	}

	public BigDecimal getHalSitscount()
	{
		return this.halSitscount;
	}

	public void setHalSitscount(BigDecimal halSitscount)
	{
		this.halSitscount = halSitscount;
	}

	public List<SitDto> getSits()
	{
		return this.sits;
	}

	public void setSits(List<SitDto> sits)
	{
		this.sits = sits;
	}
	
	@XmlElement
	private BigDecimal halId;
	@XmlTransient
	private CinemaDto cinema;
	@XmlElement
	private String halName;
	@XmlElement
	private BigDecimal halSitscount;
	@XmlElement(name="sits")
	private List<SitDto> sits = new ArrayList<SitDto>();
}
