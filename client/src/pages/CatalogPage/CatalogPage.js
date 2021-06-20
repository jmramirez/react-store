import {ProductsList} from '../../components/ProductsList/ProductsList'
import './CatalogPage.scss'
import {Filters} from "../../components/Filters/Filters";
import {useState} from 'react'

export const CatalogPage = ({ location, match, history }) => {
  const [query, setQuery] = useState('')
 
  
  return (
    <section className="catalog">
      <Filters location={location} history={history}/>
      <ProductsList location={location} query={query}/>
    </section>
  )
}