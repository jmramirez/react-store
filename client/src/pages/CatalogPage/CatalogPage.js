import {ProductsList} from '../../components/ProductsList/ProductsList'
import './CatalogPage.scss'
import {Filters} from "../../components/Filters/Filters";

export const CatalogPage = ({ location, match, history }) => {
  
  return (
    <section className="catalog">
      <Filters location={location} history={history}/>
      <ProductsList location={location} />
    </section>
  )
}