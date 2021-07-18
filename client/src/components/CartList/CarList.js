import './CarList.scss'
import { useSelector } from 'react-redux'
import {CartItem} from '../CartItem/CartItem'
import {useEffect, useState} from 'react'
import {Link} from "react-router-dom";

export const CarList = () => {
  const items = useSelector((state) => state.cart.cartItems)
  const [subtotal, setSubtotal] = useState(0)

  useEffect(() => {
    const reducer = (accumulator, cartItem) => accumulator + cartItem.subTotal;
    const total = items.reduce(reducer,0)
    setSubtotal(total)
  },[items])
  
  return (
      <div>
      {items.length ?
          (
              <ul className="cartList">
                  <li className="cartList__header">
                      <div className="cartList__header-product"><p className="cartList__header__labels">Products</p>
                      </div>
                      <div className="cartList__header-product-info"><p
                          className="cartList__header__labels">Price</p></div>
                      <div className="cartList__header-product-info"><p
                          className="cartList__header__labels">Quatity</p></div>
                      <div className="cartList__header-product-info"><p
                          className="cartList__header__labels">Subtotal</p></div>
                      <div className="cartList__header-product-action">

                      </div>
                  </li>
                  {items.map(item =>
                      <li key={item.productId + item.colorId + item.storageId} className="cartList__body">
                          <CartItem item={item}/>
                      </li>)
                  }
              </ul>
          )
          : (<p className="cartList__empty">You don't have anything in your cart yet!</p>)
      }    
      <div className="cartList-actions">
          <Link to='/' className="cartList-actions__link-back">
              <span className="material-icons cartList-actions__link-back__icon">arrow_back</span>
              <span className="cartList-actions__link-back__text">Continue Shopping</span>
          </Link>
          {
              items.length > 0 && (
                  <>
                      <div className="cartList-actions__total">
                          <p className="cartList-actions__total__content">Product Total: ${subtotal}</p>
                      </div>
                      <Link to='/' className="cartList-actions__link-check">
                      <span className="cartList-actions__link-check__text">Chekout</span>
                      <span className="material-icons cartList-actions__link-check__icon">arrow_forward</span>    
                      </Link>
                  </>
              )
          }
      </div>
      </div>  
      
  )
}