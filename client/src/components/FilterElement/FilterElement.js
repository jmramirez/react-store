import './FilterElement.scss'
import {useState} from "react";

export const FilterElement = ({ name, setQuery, active }) => {
    return(
        <div 
            className={`filter-item ${active? 'filter-item--active' : ''}`} 
            onClick={() => setQuery(name)}
        >
            <h3 className="filter-item__header">{name}</h3>
        </div>
    )
}