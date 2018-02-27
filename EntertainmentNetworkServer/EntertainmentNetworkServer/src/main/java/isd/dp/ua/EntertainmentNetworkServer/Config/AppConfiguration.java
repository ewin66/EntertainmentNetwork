package isd.dp.ua.EntertainmentNetworkServer.Config;

import org.modelmapper.ModelMapper;
import org.springframework.context.annotation.*;

@Configuration
@ComponentScan(value=
{
		"isd.dp.ua.EntertainmentNetworkServer.Config",
		"isd.dp.ua.EntertainmentNetworkServer.Common", 
		"isd.dp.ua.EntertainmentNetworkServer.Dao",
		"isd.dp.ua.EntertainmentNetworkServer.Services"})
@EnableAspectJAutoProxy(proxyTargetClass = true)
public class AppConfiguration
{
	@Bean
	public ModelMapper modelMapper()
	{
	    return new ModelMapper();
	}
}




