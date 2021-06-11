import {ProductsList} from '../../components/ProductsList/ProductsList'
import './CatalogPage.scss'
import {Filters} from "../../components/Filters/Filters";

export const CatalogPage = (props) => (
    <section className="catalog">
        <Filters />
        <ProductsList props={props} />
    </section>
)