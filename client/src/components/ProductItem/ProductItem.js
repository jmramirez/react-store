import './ProductItem.scss'

export const ProductItem = ({ product }) => (
    <div className="product">
        <div className="product-image">
            <img src={product.thumbnail} alt={product.name}/>
        </div>
        <div className="product-content">
            <h2 className="product-content__header">{product.name}</h2>
            <p className="product-content__description">{product.shortDescription}</p>
            <p className="product-content__description product-content__description--price">Price: ${product.price}</p>
            <button className="product-content__button">Add Product</button>
        </div>

    </div>
)