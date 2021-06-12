import './FilterItem.scss'

export const FilterItem = ({ title }) => (
    <div className="filter">
        <div className="filter-header">
            <h3 className="filter-header__name">{title}</h3>
            <span className="material-icons">expand_less</span>
        </div>
    </div>
)