package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

import javax.xml.bind.annotation.*;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlType
public class GenerateSeatRequest extends BaseDto
{
	public BigDecimal getFlrId()
	{
		return this.flrId;
	}

	public void setFlrId(BigDecimal flrId)
	{
		this.flrId = flrId;
	}

	public int getSeatRows()
	{
		return this.seatRows;
	}

	public void setSeatRows(int seatRows)
	{
		this.seatRows = seatRows;
	}
	
	public int getSeatColumns()
	{
		return this.seatColumns;
	}

	public void setSeatColumns(int seatColumns)
	{
		this.seatColumns = seatColumns;
	}
	
	private BigDecimal flrId;
	private int seatRows;
	private int seatColumns;
}
