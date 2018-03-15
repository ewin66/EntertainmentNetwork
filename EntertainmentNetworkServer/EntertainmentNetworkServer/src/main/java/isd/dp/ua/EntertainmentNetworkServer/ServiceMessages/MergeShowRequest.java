package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

public class MergeShowRequest extends AddShowRequest
{	
	public BigDecimal getShwId() 
	{
		return this.shwId;
	}

	public void setShwId(BigDecimal shwId)
	{
		this.shwId = shwId;
	}
	
	private BigDecimal shwId;
}
