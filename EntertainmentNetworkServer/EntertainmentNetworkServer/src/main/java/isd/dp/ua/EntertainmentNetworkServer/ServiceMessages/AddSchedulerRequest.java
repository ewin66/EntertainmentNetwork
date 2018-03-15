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
	
	public Date getSchDate() 
	{
		return this.schDate;
	}

	public void setSchDate(Date schDate) 
	{
		this.schDate = schDate;
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
	private Date schDate;
	private Date schTimeFrom;
	private Date schTimeTo;
}
