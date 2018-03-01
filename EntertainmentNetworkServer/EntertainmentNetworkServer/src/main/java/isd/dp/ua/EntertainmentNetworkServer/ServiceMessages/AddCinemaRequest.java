package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import java.math.BigDecimal;
import java.sql.Blob;

import javax.xml.bind.annotation.*;
import javax.xml.bind.annotation.adapters.XmlJavaTypeAdapter;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;
import isd.dp.ua.EntertainmentNetworkServer.Models.BlobXmlAdapter;

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

	public Blob getCinIcon()
	{
		return this.cinIcon;
	}

	public void setCinIcon(Blob cinIcon)
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
	@XmlJavaTypeAdapter(BlobXmlAdapter.class)
	private Blob cinIcon;
	private String cinAddress;
}
