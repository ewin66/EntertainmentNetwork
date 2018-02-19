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

package isd.dp.ua.EntertainmentNetworkServer.Common;
// Generated Feb 9, 2018 5:32:55 PM by Hibernate Tools 3.5.0.Final

import java.math.BigDecimal;
import java.text.NumberFormat;
import java.util.List;

import org.hibernate.SessionFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.util.Assert;

import isd.dp.ua.EntertainmentNetworkServer.Logger.Log4jHelper;

/**
 * Represents hibernate base dao operations for T model
 */
@SuppressWarnings("unchecked")
@Transactional
public class HibernateDaoOperations<T> implements ICrudOperations<T>
{
	/*
	 * Represents type of model that is handled
	 */
	private final Class<T> model;

	public HibernateDaoOperations(Class<T> model)
	{
		try	
		{
			Assert.notNull(model, "Model type could not be null");
		}
		catch (IllegalArgumentException ex)
		{
			Log4jHelper.fatal(ex);
			throw ex;
		}

		this.model = model;
	}

	/*
	 * Performs persisting (adding) item to DB
	 */
	@Override
	public void persist(T transientInstance)
	{
		Log4jHelper.debug("persisting instance: %s", transientInstance.toString());
		try
		{
			factory.getCurrentSession().persist(transientInstance);
			Log4jHelper.debug("persist successful");
		} catch (RuntimeException re)
		{
			Log4jHelper.error(re);
			throw re;
		}
	}

	/* 
	 * Performs removing item to DB
	 */
	@Override
	public void remove(T persistentInstance)
	{
		Log4jHelper.debug("removing instance: %s", persistentInstance.toString());
		try
		{
			factory.getCurrentSession().delete(persistentInstance);
			Log4jHelper.debug("remove successful");
		} catch (RuntimeException re)
		{
			Log4jHelper.error(re);
			throw re;
		}
	}

	/*  
	 * Performs merging (updating) item to DB
	 */
	@Override
	public T merge(T detachedInstance)
	{
		Log4jHelper.debug("merging instance");
		try
		{
			T result = (T) factory.getCurrentSession().merge(detachedInstance);
			Log4jHelper.debug("merge successful");
			return result;
		} catch (RuntimeException re)
		{
			Log4jHelper.error(re);
			throw re;
		}
	}

	/* 
	 * Finds item by ID
	 */
	@Override
	public T findById(BigDecimal id)
	{
		Log4jHelper.debug("getting instance with id: %s", NumberFormat.getCurrencyInstance().format(id));
		try
		{
			T instance = (T) factory.getCurrentSession().get(model, id);
			Log4jHelper.debug("get successful");
			return instance;
		} catch (RuntimeException re)
		{
			Log4jHelper.error(re);
			throw re;
		}
	}
	
	/* 
	 * Returns collection of items of type T
	 */
	@Override
	public List<T> getAll()
	{
		Log4jHelper.debug("getting all instances of type %s", this.model);		
	    return factory.getCurrentSession().createCriteria(this.model).list();
	}
	
	/*
	 * Represents hibernate factory for communication with DB
	 */
	@Autowired
	private SessionFactory factory;
}

