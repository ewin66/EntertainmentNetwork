package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

import javax.xml.bind.annotation.*;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlType
public class AddSeatRequest extends BaseDto
{
	public BigDecimal getFlrId()
	{
		return this.flrId;
	}

	public void setFlrId(BigDecimal halId)
	{
		this.flrId = halId;
	}

	public int getSeatColumn()
	{
		return this.seatColumn;
	}

	public void setSeatColumn(int seatColumn)
	{
		this.seatColumn = seatColumn;
	}
	
	public int getSeatNum()
	{
		return this.seatNum;
	}

	public void setSeatNum(int seatNum)
	{
		this.seatNum = seatNum;
	}
	
	public int getSeattRow()
	{
		return this.seatRow;
	}

	public void setSeatRow(int seatRow)
	{
		this.seatRow = seatRow;
	}
	
	public int getSeatType()
	{
		return this.seatType;
	}

	public void setSeatType(int seatType)
	{
		this.seatType = seatType;
	}
	
	public boolean getSeatIsactive() 
	{
		return this.seatIsactive;
	}

	public void setSeatIsactive(boolean seatIsactive)
	{
		this.seatIsactive = seatIsactive;
	}
	
	private BigDecimal flrId;
	private int seatNum;
	private int seatRow;
	private int seatType;
	private int seatColumn;
	private boolean seatIsactive;
	
}
