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

/*
 * Represents base CRUD operations 
 */
public interface ICrudOperations<T> 
{
	void persist(T transientInstance);

	void remove(T persistentInstance);

	T merge(T detachedInstance);

	T findById(BigDecimal id);
	
	List<T> getAll();
}