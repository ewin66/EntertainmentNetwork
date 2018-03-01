package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import javax.xml.bind.annotation.*;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlType
public class AddCityRequest extends BaseDto
{
	public String getCitCountry()
	{
		return this.citCountry;
	}

	public void setCitCountry(String citCountry)
	{
		this.citCountry = citCountry;
	}

	public String getCitName()
	{
		return this.citName;
	}

	public void setCitName(String citName)
	{
		this.citName = citName;
	}
	
	private String citName;
	private String citCountry;
}
