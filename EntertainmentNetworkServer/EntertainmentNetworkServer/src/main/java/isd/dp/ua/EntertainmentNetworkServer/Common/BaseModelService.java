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
import java.util.ArrayList;
import java.util.List;

import javax.jws.WebService;

import org.modelmapper.ModelMapper;
import org.springframework.stereotype.Service;

/*
 * Represents base implementation for service that uses dao implementation
 */
@WebService
@Service
public abstract class BaseModelService<daoOperation extends HibernateDaoOperations<entityType>, entityType extends BaseModel, dtoType extends BaseDto> 
implements ICrudOperations<dtoType>
{ 	
  /*
   * Represents web services implementation of model
   */
  protected daoOperation daoOperations;

  protected BaseModelService(daoOperation daoOperations, Class<entityType> entityType, Class<dtoType> dtoType, ModelMapper modelMapper)
  {
	  this.daoOperations = daoOperations;
	  this.entityType = entityType;
	  this.dtoType = dtoType;
	  this.modelMapper = modelMapper;
  }

  /**
   * finds item by ID  via dao implementation
   * @return T
   */
  @Override
  public dtoType findById(BigDecimal id) 
  {	
	  return this.convertToDto(daoOperations.findById(id), this.getModel());
  }
  
  /*
   * Performs persisting (adding) item via dao implementation
   */
  @Override
  public void persist(dtoType dto) 
  {
	  this.daoOperations.persist(this.convertToEntity(dto, this.getEntityModel()));
  }
  
  /*
   * Performs merge (updating) item via dao implementation
   */
  @Override
  public dtoType merge(dtoType dto)
  {
	  return this.convertToDto(this.daoOperations.merge(this.convertToEntity(dto, this.getEntityModel())), this.getModel());
  }
  
  /*
   * remove item via dao implementation
   */
  @Override
  public void remove(dtoType dto) 
  {
	  this.daoOperations.remove(this.convertToEntity(dto, this.getEntityModel()));
  }
  
  /**
   * Returns all items via dao implementation
   *  @return List<T>
   */
  @Override
  public List<dtoType> getAll() 
  {	  
	  List<dtoType> dtos = new ArrayList<dtoType>();
	  
	  for(entityType entity : this.daoOperations.getAll())
	  {
		  dtos.add(this.convertToDto(entity, this.getModel()));
	  }
	  
	  return dtos;
  }
  
  /*
   * returns type of dto 
   */
  public Class<dtoType> getModel()
  {
	  return this.dtoType;
  }
  
  /*
   * returns type of entity 
   */
  public Class<entityType> getEntityModel()
  {
	  return this.entityType;
  }
  
  /*
   * converts entity to dto 
   */
  public <X extends BaseDto> X convertToDto(BaseModel entity, Class<X> type) 
  {
	  return modelMapper.map(entity, type);
  }
  
  /*
   * converts dto to entity  
   */
  public <T extends BaseModel> T convertToEntity(BaseDto dto, Class<T> type)
  {	
	  return modelMapper.map(dto, type);
  }
  
  private final Class<dtoType> dtoType;
  private final Class<entityType> entityType;
  private final ModelMapper modelMapper;
}
