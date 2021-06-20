import './Filters.scss'
import {FiltersList} from "../FiltersList/FiltersList";

export const Filters = ({ location, history}) => (
    <div className="filters">
        <h2 className="filters__heading">Filters</h2>
        <FiltersList location={location}  history={history} />
    </div>
)