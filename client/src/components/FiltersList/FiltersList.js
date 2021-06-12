import './FiltersList.scss'
import {FilterItem} from "../FilterItem/FilterItem";

export const FiltersList = () => (
    <div className="filters-list">
        <FilterItem title="Brands"/>
        <FilterItem title="Price"/>
        <FilterItem title="Screen Size"/>
        <FilterItem title="Color"/>
        <FilterItem title="Operating System"/>
        <FilterItem title="Features"/>
        <FilterItem title="Capacity"/>
    </div>
)