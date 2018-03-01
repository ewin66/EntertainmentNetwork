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
import org.hibernate.criterion.CriteriaSpecification;
import org.hibernate.criterion.Restrictions;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import isd.dp.ua.EntertainmentNetworkServer.Common.HibernateDaoOperations;
import isd.dp.ua.EntertainmentNetworkServer.Models.Cinema;

/**
 * Home object for domain model class Cinema.
 * @see isd.dp.ua.EntertainmentNetworkServer.Models.Cinema
 * @author Hibernate Tools
 */
@Repository
@Transactional
public class CinemaDao extends HibernateDaoOperations<Cinema>
{	
	public CinemaDao()
	{
		super(Cinema.class);
	}
	
	public List<Cinema> findCinemaByName(String name)
	{
		Criteria query = this.getSeession().createCriteria(Cinema.class)
				.add(Restrictions.like("cinName", String.format("%%%s%%", name)))
				.setResultTransformer(CriteriaSpecification.DISTINCT_ROOT_ENTITY);
	    return ListCast(query);
	}
	
	public List<Cinema> findCinemaByAddress(String address)
	{
		Criteria query = this.getSeession().createCriteria(Cinema.class)
				.add(Restrictions.like("cinAddress", String.format("%%%s%%", address)))
				.setResultTransformer(CriteriaSpecification.DISTINCT_ROOT_ENTITY);
	    return ListCast(query);
	}
}
