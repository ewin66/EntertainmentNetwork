package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

public class MergeSitRequest extends AddSitRequest
{
	public BigDecimal getSitId()
	{
		return this.sitId;
	}

	public void setSitId(BigDecimal sitId)
	{
		this.sitId = sitId;
	}
	
	private BigDecimal sitId;
}
