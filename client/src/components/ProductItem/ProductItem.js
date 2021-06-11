import './ProductItem.scss'

export const ProductItem = ({ product }) => (
    <div className="product">
        <div className="product-image">
            <img src={product.thumbnail} alt={product.name}/>
        </div>
        <div className="product-action">
            <div className="product-content">
                <h2 className="product-content__header">{product.name}</h2>
                <p className="product-content__description">{product.shortDescription}</p>
                <p className="product-content__description product-content__description--price">
                    <span className="product-content__description product-content__description--span">Price:</span>
                    from* ${product.price}
                </p>
            </div>
            <button className="product-content__button">Add Product</button>
        </div>
    </div>
)