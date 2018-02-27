package isd.dp.ua.EntertainmentNetworkServer.Dto;

import java.math.BigDecimal;

import javax.xml.bind.annotation.*;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlType
public class SitDto  extends BaseDto 
{	
	public BigDecimal getSitId()
	{
		return this.sitId;
	}

	public void setSitId(BigDecimal sitId)
	{
		this.sitId = sitId;
	}

	public HallDto getHall()
	{
		return this.hall;
	}

	public void setHall(HallDto hall)
	{
		this.hall = hall;
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
	
	private BigDecimal sitId;
	@XmlTransient
	private HallDto hall;
	private BigDecimal sitNum;
	private BigDecimal sitRow;
	private BigDecimal sitFloor;
	private BigDecimal sitType;
}
