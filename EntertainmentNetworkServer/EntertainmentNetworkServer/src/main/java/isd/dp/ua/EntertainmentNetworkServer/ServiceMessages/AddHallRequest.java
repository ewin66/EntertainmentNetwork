package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

public class AddHallRequest extends BaseDto
{	
	public BigDecimal getCinId()
	{
		return this.cinId;
	}

	public void setCinId(BigDecimal cinId)
	{
		this.cinId = cinId;
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
	
	private BigDecimal cinId;
	private String halName;
	private BigDecimal halSitscount;
}
