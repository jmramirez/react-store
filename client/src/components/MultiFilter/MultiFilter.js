import './MultiFilter.scss'
import {useEffect, useRef, useState} from "react";
import {FilterElement} from "../FilterElement/FilterElement";

export const MultiFilter = ({ title, items, location, queryKey, history }) => {
    const [open, setOpen] = useState(false)
    const [elementHeight, setElementHeight] = useState(0)
    const ref = useRef(null)
    
    const searchParams = new URLSearchParams(location.search)
    let search = searchParams.get(queryKey) || ''
    let split = search.length === 0 ? [] : search.split("|")
    
    const openFilterMenu = () => {
        setOpen(!open)
    }
    
    const clearFilters =  async () => {
        try {
            searchParams.delete(queryKey)
            history.push(`/products?${searchParams}`)
            //const products = await axios.get(`https://localhost:5001/api/products?${searchParams.toString()}`)
            
        } catch (err) {
            console.log(err)
        }
    }
    
    const changeActive = async (item) => {
        try {
            if(split.indexOf(item) > -1) {
                let index = split.indexOf(item)
                split.splice(index, 1)
            } else {
                split.push(item)
            }

            if(split.length) {
                const joined = split.join('|')
                searchParams.set(queryKey,joined)
            } else {
                searchParams.delete(queryKey)
            }

            history.push(`/products?${searchParams}`)
          //  const products = await axios.get(`https://localhost:5001/api/products?${searchParams.toString()}`)
            
        } catch (err) {
            console.log(err)
        }
        
    }
    
    
    useEffect(() => {
        setElementHeight(ref.current.clientHeight)
    },[])
    
    return (
        <div className="filter">
            <div className="filter-header" onClick={openFilterMenu}>
                <h3 className="filter-header__name">{title}</h3>
                <span className={`material-icons filter-header__icon ${open? 'filter-header__icon--open' : ''}`}>expand_less</span>
            </div>
            <div className={`filter-content ${open? 'filter-content--open' : ''}`} style={{ height: open? elementHeight : ''}} >
                <ul ref={ref} className="filter-content__container">
                    <li className="filter-content__item">
                        <div 
                          className={`filter-item ${split.length? '': 'filter-item--active-all'}`}
                          onClick={clearFilters}
                        >
                            All
                        </div>
                    </li>
                    { 
                        items.map((item) =>(
                          <li className="filter-content__item" key={item.id}>
                              {<FilterElement 
                                name={item.name || item.capacity}
                                setQuery={changeActive}
                                active={split.indexOf(item.name) > -1 || split.indexOf(item.capacity)>-1}
                              />}
                          </li>
                        ))
                    }
                </ul>
            </div>
        </div>
    )
}