package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

public class MergeCityRequest extends AddCityRequest
{
	public BigDecimal getCitId()
	{
		return this.citId;
	}

	public void setCitId(BigDecimal cinId)
	{
		this.citId = cinId;
	}
	
	private BigDecimal citId;
}
