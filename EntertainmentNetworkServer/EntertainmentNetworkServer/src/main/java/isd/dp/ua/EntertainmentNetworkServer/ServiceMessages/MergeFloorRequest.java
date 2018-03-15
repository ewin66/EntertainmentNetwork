package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

public class MergeFloorRequest extends AddFloorRequest
{	
	public BigDecimal getFlrId() 
	{
		return this.flrId;
	}

	public void setFlrId(BigDecimal flrId) 
	{
		this.flrId = flrId;
	}
	
	private BigDecimal flrId;
}
