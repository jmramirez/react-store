import './CartItem.scss'
import { Link } from 'react-router-dom'
import { useDispatch} from 'react-redux'
import { removeFromCart, addProductQuantity, reduceProductQuantity } from '../../redux/actions/cartActions'

export const CartItem = ({ item }) => {
  const dispatch = useDispatch()

  const handleClick = (item) => {
    console.log(item)
    dispatch(removeFromCart(item))
  }
  
  const addProduct = (product) => {
    dispatch(addProductQuantity(product))
  }
  
  const removeProduct = (product) => {
    dispatch(reduceProductQuantity(product))
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
        <div className="cartItem-quantity__top">
          <button disabled={item.quantity < 2} className="cartItem-quantity__button" onClick={() => removeProduct(item)}>
            <span className="material-icons cartItem-quantity__button__span">remove</span>
          </button>
          <p className="cartItem-quantity__label">{item.quantity}</p>
          <button disabled={item.quantity > 9}  className="cartItem-quantity__button" onClick={() => addProduct(item)}>
            <span className="material-icons cartItem-quantity__button__span">add</span>
          </button>
        </div>
        {
          item.quantity > 9 && 
          (
            <div className="cartItem-quantity__bottom">
              10 items max.
            </div>      
          )
        }
      </div>
      <div className="cartItem-subtotal">
        <p className="cartItem-price__label"> ${item.subTotal}</p></div>
      <div className="cartItem-action">
        <button className="cartItem-action__button" onClick={() => handleClick(item)}>
          <span className="material-icons cartItem-action__button__span">delete_forever</span> Remove Item
        </button>
      </div>
    </div>
  )
}