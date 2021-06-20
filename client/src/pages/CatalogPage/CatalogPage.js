import {ProductsList} from '../../components/ProductsList/ProductsList'
import './CatalogPage.scss'
import {Filters} from "../../components/Filters/Filters";

export const CatalogPage = ({ location, match, history }) => (
    <section className="catalog">
        <Filters location={location} history={history} />
        <ProductsList  />
    </section>
)