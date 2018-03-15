package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;
import java.util.Date;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

public class AddOrderRequest extends BaseDto
{	
	public Date getOrdDate()
	{
		return this.ordDate;
	}

	public void getOrdDate(Date ordDate)
	{
		this.ordDate = ordDate;
	}
	
	public String getOrdComm() 
	{
		return this.ordComm;
	}

	public void setOrdComm(String ordComm) 
	{
		this.ordComm = ordComm;
	}
	
	public BigDecimal getOrdCost() 
	{
		return this.ordCost;
	}

	public void setOrdCost(BigDecimal ordCost) 
	{
		this.ordCost = ordCost;
	}
	
	private Date ordDate;
	private String ordComm;
	private BigDecimal ordCost;
}
