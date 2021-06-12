import './Filters.scss'
import {FiltersList} from "../FiltersList/FiltersList";

export const Filters = () => (
    <div className="filters">
        <h2 className="filters__heading">Filters</h2>
        <FiltersList />
    </div>
)