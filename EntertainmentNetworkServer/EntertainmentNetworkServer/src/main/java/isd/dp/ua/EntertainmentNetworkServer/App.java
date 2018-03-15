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
    	
    	CityDao dao = context.getBean(CityDao.class);	
    	CinemaDao cinemadao = context.getBean(CinemaDao.class);
    	SeatDao seatdao = context.getBean(SeatDao.class);
    	HallDao hallDao = context.getBean(HallDao.class);
    	FloorDao floorDao = context.getBean(FloorDao.class);
    	OrderDao orderDao = context.getBean(OrderDao.class);
    	ShowDao showDao = context.getBean(ShowDao.class);
    	SchedulerDao schedulerDao = context.getBean(SchedulerDao.class);
    	TicketDao ticketDao = context.getBean(TicketDao.class);
    	ModelMapper mapper = context.getBean(ModelMapper.class);
    	
    	Endpoint.publish("http://127.0.0.1:9998/CityService", new CityService(dao, mapper)); 
    	Endpoint.publish("http://127.0.0.1:9998/CinemaService", new CinemaService(cinemadao, dao, mapper));  	
    	Endpoint.publish("http://127.0.0.1:9998/SitService", new SeatService(seatdao, floorDao, mapper)); 
    	Endpoint.publish("http://127.0.0.1:9998/HallService", new HallService(hallDao, cinemadao, mapper)); 
    	Endpoint.publish("http://127.0.0.1:9998/FloorService", new FloorService(floorDao, hallDao, mapper)); 
    	Endpoint.publish("http://127.0.0.1:9998/OrderService", new OrderService(orderDao, mapper)); 
    	Endpoint.publish("http://127.0.0.1:9998/ShowService", new ShowService(showDao, mapper)); 
    	Endpoint.publish("http://127.0.0.1:9998/SchedulerService", new SchedulerService(showDao, hallDao, schedulerDao, mapper)); 
    	Endpoint.publish("http://127.0.0.1:9998/TicketService", new TicketService(seatdao, orderDao, schedulerDao, ticketDao, mapper)); 
    }
}
