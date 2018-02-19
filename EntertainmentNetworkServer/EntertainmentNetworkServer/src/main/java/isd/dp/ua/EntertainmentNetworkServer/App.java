package isd.dp.ua.EntertainmentNetworkServer;

import javax.xml.ws.Endpoint;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

import isd.dp.ua.EntertainmentNetworkServer.Config.AppConfiguration;
import isd.dp.ua.EntertainmentNetworkServer.Dao.CityDao;
import isd.dp.ua.EntertainmentNetworkServer.Services.CityService;

/**
 * Hello world!
 *
 */
public class App 
{	
	@Autowired
	static CityService manager2;
	
	public static void main( String[] args )
    {

    	@SuppressWarnings("resource")
    	AnnotationConfigApplicationContext context = new AnnotationConfigApplicationContext(AppConfiguration.class);   
    	CityDao dao = context.getBean("cityDao", CityDao.class);	    	
    	Endpoint.publish("http://127.0.0.1:9999/CityService", new CityService(dao));  	    
    }
}
