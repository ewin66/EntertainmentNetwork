package isd.dp.ua.EntertainmentNetworkServer;

import java.util.List;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

import isd.dp.ua.EntertainmentNetworkServer.Common.ICrudOperations;
import isd.dp.ua.EntertainmentNetworkServer.Config.AppConfiguration;
import isd.dp.ua.EntertainmentNetworkServer.Models.City;

/**
 * Hello world!
 *
 */
public class App 
{
    @SuppressWarnings({ "unchecked", "unused" })
	public static void main( String[] args )
    {
    	
    	@SuppressWarnings("resource")
    	AnnotationConfigApplicationContext context = new AnnotationConfigApplicationContext(AppConfiguration.class);   
    	ICrudOperations<City> manager = (ICrudOperations<City>) context.getBean("cinemaService");
  	  
		List<City> list = manager.getAll();
	    
	    City city = new City();
	    city.setCitCountry("UA");
	    city.setCitName("BRD");
	    manager.persist(city);
	    
	    list = manager.getAll();   	    

    }
}
