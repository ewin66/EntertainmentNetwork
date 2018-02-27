package isd.dp.ua.EntertainmentNetworkServer.Dto;

import java.sql.Blob;
import javax.xml.bind.annotation.adapters.XmlAdapter;
import org.hibernate.Hibernate;
import org.hibernate.SessionFactory;

import com.bea.core.repackaged.springframework.beans.factory.annotation.Autowired;

public class BlobXmlAdapter extends XmlAdapter<String, Blob> 
{
	@Autowired
	private SessionFactory factory;
	@Override
	public Blob unmarshal(String v) throws Exception 
	{
		if (v ==null) v= "";
		return Hibernate.getLobCreator(factory.getCurrentSession()).createBlob(v.getBytes());
	}
	
	@Override
	public String marshal(Blob v) throws Exception 
	{
		if (v == null) return "";
		return v.getBytes(1l, (int)v.length()).toString();
	}
}
