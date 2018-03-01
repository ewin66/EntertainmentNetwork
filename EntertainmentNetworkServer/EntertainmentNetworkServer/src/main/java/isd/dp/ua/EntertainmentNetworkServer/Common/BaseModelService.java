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

import javax.jws.WebService;

import org.modelmapper.ModelMapper;
import org.springframework.stereotype.Service;

/*
 * Represents base implementation for service that uses dao implementation
 */
@WebService
@Service
public abstract class BaseModelService 
{ 	
  protected BaseModelService(ModelMapper modelMapper)
  {
	  this.modelMapper = modelMapper;
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
  
  private final ModelMapper modelMapper;
}
