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

import javax.persistence.criteria.*;

//import org.hibernate.criterion.CriteriaQuery;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import isd.dp.ua.EntertainmentNetworkServer.Common.HibernateDaoOperations;
import isd.dp.ua.EntertainmentNetworkServer.Models.City;

/**
 * Home object for domain model class City.
 * @see isd.dp.ua.EntertainmentNetworkServer.Models.City
 * @author Hibernate Tools
 */
@Repository
@Transactional
public class CityDao extends HibernateDaoOperations<City>
{
	public CityDao()
	{
		super(City.class);
	}
	
	public List<City> findByName(String name)
	{
	    CriteriaBuilder builder = getEntityManager().getCriteriaBuilder();
	    CriteriaQuery<City> query = builder.createQuery(City.class);
	    Root<City> cities = query.from(City.class);
	    query.select(cities).where(builder.equal(cities.get("citName"), name));

	    return getEntityManager().createQuery(query).getResultList();
	}
}
