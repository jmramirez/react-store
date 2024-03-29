import './ProductsList.scss'
import {useEffect, useState} from 'react'
import axios from 'axios'
import {ProductItem} from "../ProductItem/ProductItem";
import { webAPIURL } from '../../AppSettings';

export const ProductsList = ({ location }) => {
  const [products, setProducts] = useState([])
  
  useEffect(() => {
    const getProducts = async () => {
      try {
        const response = await axios.get(`${webAPIURL}/products${location.search}`)
        setProducts(response.data)
      } catch (e) {
        console.log(e)
      }
    }
    getProducts()
  }, [location.search])
  
  

  return(
    <div className="products">
      <h1 className="products__header">Phones</h1>
      <ul className="products__list">
        { products.map((product) => (
          <li key={product.id}>
            <ProductItem product={product}/>
          </li>
        ))}
      </ul>
    </div>
  )
}