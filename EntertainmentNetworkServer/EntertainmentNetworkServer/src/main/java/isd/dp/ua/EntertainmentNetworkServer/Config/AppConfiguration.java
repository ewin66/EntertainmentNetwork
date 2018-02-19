package isd.dp.ua.EntertainmentNetworkServer.Config;

import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.EnableAspectJAutoProxy;

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
}




