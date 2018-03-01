package isd.dp.ua.EntertainmentNetworkServer;

import javax.xml.ws.Endpoint;

import org.modelmapper.ModelMapper;
import org.springframework.boot.web.support.SpringBootServletInitializer;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.springframework.web.WebApplicationInitializer;

import isd.dp.ua.EntertainmentNetworkServer.Config.AppConfiguration;
import isd.dp.ua.EntertainmentNetworkServer.Dao.*;
import isd.dp.ua.EntertainmentNetworkServer.Services.*;

/**
 * Hello world!
 *
 */
public class App extends SpringBootServletInitializer implements WebApplicationInitializer
{	
	public static void main( String[] args )
    {
    	@SuppressWarnings("resource")
    	AnnotationConfigApplicationContext context = new AnnotationConfigApplicationContext(AppConfiguration.class);   
    	
    	CityDao dao = context.getBean("cityDao", CityDao.class);	
    	CinemaDao cinemadao = context.getBean("cinemaDao", CinemaDao.class);
    	SitDao sitdao = context.getBean("sitDao", SitDao.class);
    	HallDao hallDao = context.getBean("hallDao", HallDao.class);
    	
    	ModelMapper mapper = context.getBean("modelMapper", ModelMapper.class);
    	
    	Endpoint.publish("http://127.0.0.1:9998/CityService", new CityService(dao, mapper)); 
    	Endpoint.publish("http://127.0.0.1:9998/CinemaService", new CinemaService(cinemadao, dao, mapper));  	
    	Endpoint.publish("http://127.0.0.1:9998/SitService", new SitService(sitdao, hallDao, mapper)); 
    	Endpoint.publish("http://127.0.0.1:9998/HallService", new HallService(hallDao, cinemadao, mapper)); 
    }
}
