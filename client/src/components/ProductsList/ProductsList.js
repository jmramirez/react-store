import './ProductsList.scss'
import {useEffect, useState} from 'react'
import axios from 'axios'

export const ProductsList = () => {
  
  const [products, setProducts] = useState([])

  useEffect(() => {
    const getProducts = async () => {
      try {
        const response = await axios.get('https://localhost:5001/api/products')
        setProducts(response.data)
      } catch (e) {
        console.log(e)
      }
    }
    getProducts()
  }, [])

  return(
    <>
      <h1>Product Page</h1>
      <ul>
        { products.map((product) => (
          <li key={product.id}>
            {product.name}
          </li>
        ))}
      </ul>
    </>
  )
}