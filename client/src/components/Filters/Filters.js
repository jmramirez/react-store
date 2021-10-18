import './Filters.scss'
import {FiltersList} from "../FiltersList/FiltersList";
import { useState} from 'react';

export const Filters = ({ location, history}) => {
  const [openList, setOpenList] = useState(false)


  const showMenu = () => {
    setOpenList(!openList)
  }

  return(
    <div className="filters">
      <div className="filters__header"><h2 className="filters__header__heading">Filters</h2></div>
      <div className="filters__header filters__header--button" onClick={showMenu}><h2 className="filters__header__heading">Filters</h2><span className={`material-icons filters__header__icon ${openList? 'filters__header__icon--open': ''}`}>arrow_forward_ios</span></div>
      <FiltersList location={location}  history={history} open={openList}/>
    </div>
  )
}