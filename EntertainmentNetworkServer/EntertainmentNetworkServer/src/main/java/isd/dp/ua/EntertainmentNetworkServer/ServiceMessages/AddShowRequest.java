package isd.dp.ua.EntertainmentNetworkServer.ServiceMessages;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseDto;

public class AddShowRequest extends BaseDto
{	
	public String getShwName() 
	{
		return this.shwName;
	}

	public void setShwName(String shwName) 
	{
		this.shwName = shwName;
	}

	public String getShwDescr() 
	{
		return this.shwDescr;
	}

	public void setShwDescr(String shwDescr) 
	{
		this.shwDescr = shwDescr;
	}

	public byte[] getShwIcon()
	{
		return this.shwIcon;
	}

	public void setShwIcon(byte[] shwIcon) 
	{
		this.shwIcon = shwIcon;
	}
	
	private String shwName;
	private String shwDescr;
	private byte[] shwIcon;
}
