﻿import './FiltersList.scss'
import {useEffect, useState} from "react";
import axios from "axios";
import {MultiFilter} from "../MultiFilter/MultiFilter";
import { webAPIURL } from '../../AppSettings';

export const FiltersList = ({ location, history, open }) => {
  const [filtersItems, setFiltersItems] = useState([])
  const [loading, setLoading] = useState(true)
        

    useEffect(() => {
      const getFilters = async () =>{
        try {
          const filters = await axios.get(`${webAPIURL}/filters`)
          setFiltersItems(filters.data)
          setLoading(false)
        } catch (e){
          console.log(e)
        }
      }
      getFilters()
    }, [])
  
        
    return (
      loading ? <div>Loading...</div> 
        : 
      <div className={open? "filters-list filters-list--open" : "filters-list"}>
        <MultiFilter title="Brands" items={filtersItems.brands} location={location} history={history} queryKey="brands" />
        <MultiFilter title="Color" items={filtersItems.colors} location={location} history={history} queryKey="colors"/>
        <MultiFilter title="Operating System" items={filtersItems.os} location={location} history={history} queryKey="os" />
        <MultiFilter title="Features" items={filtersItems.features} location={location} history={history} queryKey="features"/>
        <MultiFilter title="Capacity" items={filtersItems.capacity} location={location} history={history} queryKey="storage"/>
      </div>    
    )
}