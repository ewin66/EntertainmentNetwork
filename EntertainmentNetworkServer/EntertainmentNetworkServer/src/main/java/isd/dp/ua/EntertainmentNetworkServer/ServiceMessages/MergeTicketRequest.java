package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

public class MergeTicketRequest extends AddTicketRequest
{	
	public BigDecimal getTctId() 
	{
		return this.tctId;
	}

	public void setTctId(BigDecimal tctId)
	{
		this.tctId = tctId;
	}
	
	private BigDecimal tctId;
}
