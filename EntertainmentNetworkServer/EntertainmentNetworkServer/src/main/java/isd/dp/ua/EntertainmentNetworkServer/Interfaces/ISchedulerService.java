package isd.dp.ua.EntertainmentNetworkServer.Interfaces;

import java.math.BigDecimal;
import java.util.List;

import javax.jws.WebService;

import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService
public interface ISchedulerService 
{
	void addScheduler(AddSchedulerRequest show);

	Scheduler findSchedulerById(BigDecimal id);
	
	List<Scheduler> getSchedulers();
	
	Scheduler mergeScheduler(MergeSchedulerRequest show);
	
	void removeScheduler(BigDecimal id);
}
