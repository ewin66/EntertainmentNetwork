package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

public class AddFloorRequest extends BaseDto
{	
	public BigDecimal getHalId()
	{
		return this.halId;
	}

	public void setHalId(BigDecimal halId)
	{
		this.halId = halId;
	}
	
	public String getFlrName() 
	{
		return this.flrName;
	}

	public void setFlrName(String flrName) 
	{
		this.flrName = flrName;
	}
	
	private BigDecimal halId;
	private String flrName;
}
