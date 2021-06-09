import {ProductsList} from '../../components/ProductsList/ProductsList'
import './CatalogPage.scss'

export const CatalogPage = (props) => (
  <section className="catalog">
    <ProductsList props={props} />
  </section>
)