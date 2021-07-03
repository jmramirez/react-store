import './CartItem.scss'
import { Link } from 'react-router-dom'

export const CartItem = ({ item }) => {

  const handleClick = () => {
    console.log(item)
  }

  return(
    <div className="cartItem">
      <div className="cartItem-product">
        <Link to={`/products/${item.slug}`} className="cartItem-product__image">
          <img src={item.thumbnail} alt="prod_img" className="cartItem-product__image__thumb" />
        </Link>
        <div className="cartItem-product__details">
          <p className="cartItem-product__details__label__name">{item.name}</p>
          <p className="cartItem-product__details__label">
            <span className="cartItem-product__details__label__name">Color:</span> {item.color}
          </p>
          <p className="cartItem-product__details__label">
            <span className="cartItem-product__details__label__name">Capacity: </span> {item.capacity}
          </p>
        </div>
      </div>
      <div className="cartItem-price">
        <p className="cartItem-price__label">${item.price}</p>
      </div>
      <div className="cartItem-quantity">
        <button disabled={item.quantity < 2} className="cartItem-quantity__button">
          <span className="material-icons cartItem-quantity__button__span">remove</span>
        </button>
        <p className="cartItem-quantity__label">{item.quantity}</p>
        <button className="cartItem-quantity__button">
          <span className="material-icons cartItem-quantity__button__span">add</span>
        </button>
      </div>
      <div className="cartItem-subtotal">
        <p className="cartItem-price__label"> ${item.subTotal}</p></div>
      <div className="cartItem-action">
        <button className="cartItem-action__button">
          <span className="material-icons cartItem-action__button__span">delete_forever</span> Remove Item
        </button>
      </div>
    </div>
  )
}