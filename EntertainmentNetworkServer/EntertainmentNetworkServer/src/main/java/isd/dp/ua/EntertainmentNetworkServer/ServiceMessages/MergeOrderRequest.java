package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

public class MergeOrderRequest extends AddOrderRequest
{
	public BigDecimal getOrdId() 
	{
		return this.ordId;
	}

	public void setOrdId(BigDecimal ordId) 
	{
		this.ordId = ordId;
	}
	
	private BigDecimal ordId;
}
