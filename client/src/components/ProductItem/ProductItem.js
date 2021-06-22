import './ProductItem.scss'
import {Link} from 'react-router-dom'

export const ProductItem = ({ product }) => (
    <div className="product">
        <div className="product-image">
            <img src={product.thumbnail} alt={product.name} className="product-image__src"/>
        </div>
        <div className="product-action">
            <div className="product-content">
              <Link to={`/products/${product.slug}`}>
                <h2 className="product-content__header">{product.name}</h2>
              </Link>
                <p className="product-content__description">{product.shortDescription}</p>
                <p className="product-content__description product-content__description--price">
                    <span className="product-content__description product-content__description--span">Price:</span>
                    from* ${product.price}
                </p>
            </div>
          <button className="product-content__button"><span className="product-content__button__text">Mode Details</span><span className="material-icons product-content__button__icon">arrow_forward</span></button>
        </div>
    </div>
)