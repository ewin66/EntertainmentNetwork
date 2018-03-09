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

package isd.dp.ua.EntertainmentNetworkServer.Models;
// Generated Feb 9, 2018 5:32:55 PM by Hibernate Tools 3.5.0.Final

import java.math.BigDecimal;
import java.util.HashSet;
import java.util.Set;

import javax.persistence.*;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlTransient;
import javax.xml.bind.annotation.XmlType;

import isd.dp.ua.EntertainmentNetworkServer.Common.BaseModel;

/**
 * Hall generated by hbm2java
 */
@SuppressWarnings("serial")
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType
@Entity
@Table(name = "HALL", schema = "PBAB")
public class Hall extends BaseModel implements java.io.Serializable
{
	private BigDecimal halId;
	@XmlTransient
	private Cinema cinema;
	private String halName;
	private BigDecimal halSitscount;
	private Set<Sit> sits = new HashSet<Sit>(0);

	public Hall()
	{
	}

	public Hall(BigDecimal halId, Cinema cinema, String halName, BigDecimal halSitscount)
	{
		this.halId = halId;
		this.cinema = cinema;
		this.halName = halName;
		this.halSitscount = halSitscount;
	}

	public Hall(BigDecimal halId, Cinema cinema, String halName, BigDecimal halSitscount, Set<Sit> sits)
	{
		this.halId = halId;
		this.cinema = cinema;
		this.halName = halName;
		this.halSitscount = halSitscount;
		this.sits = sits;
	}

	@Id
	@GeneratedValue(strategy = GenerationType.SEQUENCE, generator = "HALL_SEQ")
    @SequenceGenerator(name = "HALL_SEQ", sequenceName = "HALL_SEQ")
	@Column(name = "HAL_ID", unique = true, nullable = false, precision = 22, scale = 0)
	public BigDecimal getHalId()
	{
		return this.halId;
	}

	public void setHalId(BigDecimal halId)
	{
		this.halId = halId;
	}

	@ManyToOne(fetch = FetchType.EAGER)
	@JoinColumn(name = "HAL_CIN_ID", nullable = false)
	public Cinema getCinema()
	{
		return this.cinema;
	}

	public void setCinema(Cinema cinema)
	{
		this.cinema = cinema;
	}
	
	@Transient
	@XmlElement
	public BigDecimal getCinemaId()
	{
		return this.getCinema() == null ? new BigDecimal("-1") : this.getCinema().getCinId();
	}

	@Column(name = "HAL_NAME", nullable = false, length = 100)
	public String getHalName()
	{
		return this.halName;
	}

	public void setHalName(String halName)
	{
		this.halName = halName;
	}

	@Column(name = "HAL_SITSCOUNT", nullable = false, precision = 22, scale = 0)
	public BigDecimal getHalSitscount()
	{
		return this.halSitscount;
	}

	public void setHalSitscount(BigDecimal halSitscount)
	{
		this.halSitscount = halSitscount;
	}

	@OneToMany(cascade={CascadeType.MERGE}, fetch = FetchType.EAGER, mappedBy = "hall")
	public Set<Sit> getSits()
	{
		return this.sits;
	}

	public void setSits(Set<Sit> sits)
	{
		this.sits = sits;
	}

	@Override
	public String toString()
	{
		return "Hall [halId=" + halId + ", halName=" + halName + "]";
	}
}
