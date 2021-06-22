import {useEffect, useState} from 'react'
import axios from 'axios'
import './ProductPage.scss'
import {Link} from 'react-router-dom'

export const ProductPage = ({ match, history }) => {
  const [product, setProduct] = useState(null)
  
  useEffect(() => {
    const getProduct = async (slug) => {
      const product = await axios.get(`https://localhost:5001/api/products/${slug}`)
      setProduct(product.data)
    }
    if(match.params.productSlug) {
      const slug = match.params.productSlug
      getProduct(slug)
    }
  }, [match.params.productSlug])
  
  return (
    <section className="product-details">
      <div className="product-details-top">
        <Link to='/products' className="product-details-top__link"><span className="material-icons product-details-top__link__icon">arrow_back</span><span className="product-details-top__link__text">Return to Products</span></Link>
        <div className="product-details-top__images">
          
        </div>
        <div className="product-details-top__content">

        </div>
      </div>
      <div className="product-details-bottom">

      </div>
    </section>
  )
}