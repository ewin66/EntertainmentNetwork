package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;
import java.util.Date;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

public class AddSchedulerRequest extends BaseDto
{	
	public BigDecimal getHalId() 
	{
		return this.halId;
	}

	public void setHalId(BigDecimal halId)
	{
		this.halId = halId;
	}
	
	public BigDecimal getShwId()
	{
		return this.shwId;
	}

	public void setShwId(BigDecimal shwId) 
	{
		this.shwId = shwId;
	}
	
	public String getSchName() 
	{
		return this.schName;
	}

	public void setSchName(String schName) 
	{
		this.schName = schName;
	}

	public String getSchDescr() 
	{
		return this.schDescr;
	}

	public void setSchDescr(String schDescr) 
	{
		this.schDescr = schDescr;
	}

	public Date getSchTimeFrom() 
	{
		return this.schTimeFrom;
	}

	public void setSchTimeFrom(Date schTimeFrom)
	{
		this.schTimeFrom = schTimeFrom;
	}

	public Date getSchTimeTo() 
	{
		return this.schTimeTo;
	}

	public void setSchTimeTo(Date schTimeTo)
	{
		this.schTimeTo = schTimeTo;
	}
	
	private BigDecimal halId;
	private BigDecimal shwId;
	private String schName;
	private String schDescr;
	private Date schTimeFrom;
	private Date schTimeTo;
}
