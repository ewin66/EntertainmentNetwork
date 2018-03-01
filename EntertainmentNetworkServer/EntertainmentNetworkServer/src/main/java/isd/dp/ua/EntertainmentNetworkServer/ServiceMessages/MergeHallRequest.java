package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

public class MergeHallRequest extends AddHallRequest
{	
	public BigDecimal getHalId()
	{
		return this.halId;
	}

	public void setHalId(BigDecimal halId)
	{
		this.halId = halId;
	}
	
	private BigDecimal halId;
}
