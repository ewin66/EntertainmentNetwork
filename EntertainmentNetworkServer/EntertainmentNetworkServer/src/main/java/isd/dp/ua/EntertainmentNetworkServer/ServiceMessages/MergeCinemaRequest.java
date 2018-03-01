package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

public class MergeCinemaRequest extends AddCinemaRequest
{
	public BigDecimal getCinId()
	{
		return this.cinId;
	}

	public void setCinId(BigDecimal cinId)
	{
		this.cinId = cinId;
	}
	
	private BigDecimal cinId;
}
