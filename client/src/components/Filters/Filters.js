import './Filters.scss'
import {FiltersList} from "../FiltersList/FiltersList";

export const Filters = ({ location, history}) => (
    <div className="filters">
        <div className="filters__header"><h2 className="filters__header__heading">Filters</h2><span className={`material-icons filters__header__icon `}>arrow_forward_ios</span></div>
        <FiltersList location={location}  history={history} />
    </div>
)