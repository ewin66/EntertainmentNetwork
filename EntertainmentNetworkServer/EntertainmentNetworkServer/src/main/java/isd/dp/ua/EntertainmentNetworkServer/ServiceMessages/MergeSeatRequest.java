package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

public class MergeSeatRequest extends AddSeatRequest
{
	public BigDecimal getSeatId()
	{
		return this.seatId;
	}

	public void setSeatId(BigDecimal sitId)
	{
		this.seatId = sitId;
	}
	
	private BigDecimal seatId;
}
