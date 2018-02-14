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

import java.math.BigDecimal;
import java.util.List;

import org.springframework.transaction.annotation.Transactional;

/*
 * Represents base implementation for service that uses dao implementation
 */
@Transactional
public abstract class BaseModelService<T> implements ICrudOperations<T>
{ 	
  /*
   * Represents dao implementation of model
   */
  protected ICrudOperations<T> daoOperations;
  
  protected BaseModelService(ICrudOperations<T> daoOperations)
  {
	  this.daoOperations = daoOperations;
  }
  
  /*
   * Performs persisting (adding) item via dao implementation
   */
  @Override
  public void persist(T item) 
  {
	  daoOperations.persist(item);
  }
  
  /*
   * Performs merge (updating) item via dao implementation
   */
  @Override
  public T merge(T detachedInstance)
  {
  	// TODO Auto-generated method stub
  	return null;
  }
  
  /*
   * remove item via dao implementation
   */
  @Override
  public void remove(T user) 
  {
	  daoOperations.remove(user);
  }
  
  /**
   * Returns all items via dao implementation
   *  @return List<T>
   */
  @Override
  public List<T> getAll() 
  {
    return daoOperations.getAll();
  }
  
  /**
   * finds item by ID  via dao implementation
   * @return T
   */
  @Override
  public T findById(BigDecimal id)
  {
	  return daoOperations.findById(id);
  }
}
