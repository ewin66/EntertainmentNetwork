package isd.dp.ua.EntertainmentNetworkServer.Interfaces;

import java.math.BigDecimal;
import java.util.List;

import javax.jws.WebService;

import isd.dp.ua.EntertainmentNetworkServer.Models.*;
import isd.dp.ua.EntertainmentNetworkServer.ServiceMessages.*;

@WebService
public interface IOrderService 
{
	void addOrder(AddOrderRequest order);

	Orders findOrderById(BigDecimal id);
	
	List<Orders> getOrders();
	
	Orders mergeOrder(MergeOrderRequest order);
	
	void removeOrder(BigDecimal id);
}
