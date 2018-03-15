package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

public class MergeSchedulerRequest extends AddSchedulerRequest
{	
	public BigDecimal getSchId() 
	{
		return this.schId;
	}

	public void setSchId(BigDecimal schId)
	{
		this.schId = schId;
	}
	
	private BigDecimal schId;
}
