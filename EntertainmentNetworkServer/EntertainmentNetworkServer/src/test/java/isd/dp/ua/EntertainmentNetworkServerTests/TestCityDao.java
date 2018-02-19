package isd.dp.ua.EntertainmentNetworkServerTests;

import java.util.List;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.annotation.Rollback;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;
import org.springframework.transaction.annotation.Transactional;

import isd.dp.ua.EntertainmentNetworkServer.Config.AppConfiguration;
import isd.dp.ua.EntertainmentNetworkServer.Dao.CityDao;
import isd.dp.ua.EntertainmentNetworkServer.Models.City;
import junit.framework.Assert;

@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration(classes = {AppConfiguration.class})
public class TestCityDao
{
	@Autowired
	CityDao manager;
	 
	@Transactional
    @Rollback(true)
	@Test
	public void testCityCreation()
	{	 
		List<City> citiesBefore = manager.getAll();  
		City city = new City();
	    city.setCitCountry("UA");
	    city.setCitName("BRD");
	    manager.persist(city);
	    List<City> citiesAfter = manager.getAll();        
        Assert.assertEquals(citiesBefore.size() + 1, citiesAfter.size());	    
	}
}
