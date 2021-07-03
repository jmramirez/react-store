import './CarList.scss'
import { useSelector } from 'react-redux'
import {CartItem} from '../CartItem/CartItem'
import {useEffect, useState} from 'react'

export const CarList = () => {
  const items = useSelector((state) => state.cart.cartItems)
  const [subtotal, setSubtotal] = useState(0)

  useEffect(() => {
    const reducer = (accumulator, cartItem) => accumulator + cartItem.subTotal;
    const total = items.reduce(reducer,0)
    setSubtotal(total)
  },[items])
  
  return (
    <ul>
      <li className="cartList__header">
        <div className="cartList__header-product"><p className="cartList__header__labels">Products</p></div>
        <div className="cartList__header-product-info"><p className="cartList__header__labels">Price</p></div>
        <div className="cartList__header-product-info"><p className="cartList__header__labels">Quatity</p></div>
        <div className="cartList__header-product-info"><p className="cartList__header__labels">Subtotal</p></div>
        <div className="cartList__header-product-action">

        </div>
      </li>
      {items.map(item => 
        <li key={item.productId + item.colorId + item.storageId} className="cartList__body">
          <CartItem item={item} />
        </li>)}
    </ul>
  )
}