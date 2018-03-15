package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

public class AddTicketRequest extends BaseDto
{	
	public BigDecimal getSchId() 
	{
		return this.schId;
	}

	public void setSchId(BigDecimal schId)
	{
		this.schId = schId;
	}

	public BigDecimal getSeatId() 
	{
		return this.seatId;
	}

	public void setSeatId(BigDecimal seatId) 
	{
		this.seatId = seatId;
	}

	public BigDecimal getOrdId()
	{
		return this.ordId;
	}

	public void setOrdId(BigDecimal ordId) 
	{
		this.ordId = ordId;
	}

	public BigDecimal getTctPrice()
	{
		return this.tctPrice;
	}

	public void setTctPrice(BigDecimal tctPrice) 
	{
		this.tctPrice = tctPrice;
	}

	public boolean isTctIssold() 
	{
		return this.tctIssold;
	}

	public void setTctIssold(boolean tctIssold)
	{
		this.tctIssold = tctIssold;
	}
	
	private BigDecimal schId;
	private BigDecimal seatId;
	private BigDecimal ordId;
	private BigDecimal tctPrice;
	private boolean tctIssold;
}
