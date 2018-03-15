/* 
* This module is part of the Entertainment Network system 
* Copyright (c) SCC Soft Computer, Inc. 2018 
* All Rights Reserved 
* 
* This document contains unpublished, confidential and proprietary 
* information of SCC Soft Computer, Inc. No disclosure or use of 
* any portion of the contents of these materials may be made without the 
* express written consent of Soft Computer Consultants, Inc. 
* 
*/ 

package isd.dp.ua.EntertainmentNetworkServer.Dao;
// Generated Feb 9, 2018 5:32:55 PM by Hibernate Tools 3.5.0.Final

import java.util.List;

import org.hibernate.Criteria;
import org.hibernate.Session;
import org.hibernate.criterion.CriteriaSpecification;
import org.hibernate.criterion.Restrictions;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import isd.dp.ua.EntertainmentNetworkServer.Common.HibernateDaoOperations;
import isd.dp.ua.EntertainmentNetworkServer.Logger.Log4jHelper;
import isd.dp.ua.EntertainmentNetworkServer.Models.*;

/**
 * Home object for domain model class Sit.
 * @see isd.dp.ua.EntertainmentNetworkServer.Models.Sit
 * @author Hibernate Tools
 */
@Repository
@Transactional
public class SeatDao extends HibernateDaoOperations<Seat>
{
	public SeatDao()
	{
		super(Seat.class);
	}
	
	public void addSeats(List<Seat> seats)
	{
		Log4jHelper.debug("generating seats");
		try
		{		
			Session session = this.getSeession();
			int batchSize = Integer.parseInt(getSessionConfig().getProperty("hibernate.jdbc.batch_size"));
			for (int i = 0; i < seats.size(); i++ ) 
			{			    
			    session.save(seats.get(i));
			    if (i % batchSize == 0 ) 
			    { 
			        session.flush();
			        session.clear();
			    }
			}		

			Log4jHelper.debug("generating seats is completed");
		} catch (RuntimeException re)
		{
			Log4jHelper.error(re);
			throw re;
		}		
	}
}
