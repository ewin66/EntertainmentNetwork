package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;

import javax.xml.bind.annotation.*;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlType
public class AddCinemaRequest extends BaseDto
{
	public BigDecimal getCitId()
	{
		return this.citId;
	}

	public void setCitId(BigDecimal citId)
	{
		this.citId = citId;
	}
	
	public String getCinName()
	{
		return this.cinName;
	}

	public void setCinName(String cinName)
	{
		this.cinName = cinName;
	}

	public byte[] getCinIcon()
	{
		return this.cinIcon;
	}

	public void setCinIcon(byte[] cinIcon)
	{
		this.cinIcon = cinIcon;
	}

	public String getCinAddress()
	{
		return this.cinAddress;
	}

	public void setCinAddress(String cinAddress)
	{
		this.cinAddress = cinAddress;
	}
	
	private BigDecimal citId;
	private String cinName;
	private byte[] cinIcon;
	private String cinAddress;
}
