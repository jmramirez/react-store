import {useEffect, useState} from 'react'
import axios from 'axios'
import './ProductPage.scss'
import {Link} from 'react-router-dom'
import {ProductImage} from '../../components/ProductImage/ProductImage'

export const ProductPage = ({ match, history }) => {
  const [product, setProduct] = useState(null)
  const [loading, setLoading] = useState(true)
  const [disabled, setDisabled] = useState(true)
  const [color, setColor] = useState('')
  
  useEffect(() => {
    const getProduct = async (slug) => {
      const product = await axios.get(`https://localhost:5001/api/products/${slug}`)
      setProduct(product.data)
      setLoading(false)
    }
    if(match.params.productSlug) {
      const slug = match.params.productSlug
      getProduct(slug)
    }
  }, [match.params.productSlug])
  
  return (
    <section className="product-details">
      <Link to='/products' className="product-details-top__link"><span className="material-icons product-details-top__link__icon">arrow_back</span><span className="product-details-top__link__text">Return to Products</span></Link>
      {
        loading ? <h2>Loading...</h2>
          :
          <>
            <div className="product-details-top">
              <div className="product-details-top__images">
                <ProductImage images={product.images} />
              </div>
              <div className="product-details-top__content">
                <h2 className="product-details-top__content-heading">{product.name}</h2>
                <p className="product-details-top__content-paragraph">{product.shortDescription}</p>
                <h3 className="product-details-top__content-subHeading">Features:</h3>
                <ul className="product-details-top__content-list">
                  {product.features.map((feature) => <li key={feature.id}>{feature.name}</li>)}
                </ul>
                <h4 className="product-details-top__content-subHeading">Variants:</h4>
                <p className="product-details-top__content-variant">Color:</p>
                <select id="color" name="color" value={color} className="product-details-top__content-variant__select">
                  <option value="" disabled defaultValue>Please select</option>
                  <option value="blue">Blue</option>
                </select>
                <p className="product-details-top__content-variant">Storage:</p>
                <select id="color" name="color" value={color} className="product-details-top__content-variant__select" disabled={disabled}>
                  <option value="" disabled defaultValue>Please select</option>
                </select>
              </div>
            </div>
            <div className="product-details-bottom">
              <h5 className="product-details-bottom__heading">Product Details</h5>
              <p className="product-details-bottom__paragraph">{product.description}</p>
            </div>
          </>
      }
    </section>
  )
}