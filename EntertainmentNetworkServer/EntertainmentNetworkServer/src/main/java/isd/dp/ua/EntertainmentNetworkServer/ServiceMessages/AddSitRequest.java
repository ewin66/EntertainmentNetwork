package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

import javax.xml.bind.annotation.*;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlType
public class AddSitRequest extends BaseDto
{
	public BigDecimal getHalId()
	{
		return this.halId;
	}

	public void setHalId(BigDecimal halId)
	{
		this.halId = halId;
	}

	public BigDecimal getSitNum()
	{
		return this.sitNum;
	}

	public void setSitNum(BigDecimal sitNum)
	{
		this.sitNum = sitNum;
	}
	
	public BigDecimal getSitRow()
	{
		return this.sitRow;
	}

	public void setSitRow(BigDecimal sitRow)
	{
		this.sitRow = sitRow;
	}
	
	public BigDecimal getSitFloor()
	{
		return this.sitFloor;
	}

	public void setSitFloor(BigDecimal sitFloor)
	{
		this.sitFloor = sitFloor;
	}
	
	public BigDecimal getSitType()
	{
		return this.sitType;
	}

	public void setSitType(BigDecimal sitType)
	{
		this.sitType = sitType;
	}
	
	private BigDecimal halId;
	private BigDecimal sitNum;
	private BigDecimal sitRow;
	private BigDecimal sitFloor;
	private BigDecimal sitType;
}
