import './Header.scss'
import {Link} from 'react-router-dom'
import { useSelector} from 'react-redux'
import {useEffect, useState} from 'react'
import Modal from "../Modal/Modal";
import { useDispatch } from "react-redux";
import { showAuthModal} from "../../redux/actions/modalActions";

export const Header = () => {
  const items = useSelector((state) => state.cart.cartItems)
  const modalOpen = useSelector((state) => state.modal.showAuthModal)
  const [totalItems, setTotalItems] = useState(0)
  const dispatch = useDispatch()
  const [action, setAction] = useState('')
  
  useEffect(() => {
    const reducer = (accumulator, cartItem) => accumulator + cartItem.quantity;
    const totalItems = items.reduce(reducer, 0)
    setTotalItems(totalItems)
  }, [items])
  
  const openModal = (action) => {
    setAction(action)
    dispatch(showAuthModal())
  } 
  
  
  return (
    <header className="header">
      <nav className="header-nav">
        <Link to="/" className="header-nav__heading">
          CoreNETStore
        </Link>
        <div className="header-nav__links">
          <div className="header-nav__links-auth">
            <span className="material-icons header-nav__links-auth__icon">
              account_circle
            </span>
            Sign In
            <div className="header-nav__links-auth__test">
              <button className="header-nav__links-auth__test__auth-sign" onClick={() => openModal('signin')}>
                Sign In
              </button>
              <button className="header-nav__links-auth__test__auth-create" onClick={() => openModal('signup')}>
                Create Account
              </button>
            </div>
          </div>
          <Link to="/cart" className="header-nav__shoppingCart">
            <span className="material-icons header-nav__shoppingCart__icon">shopping_cart</span>
            {totalItems ? `(${totalItems} Items)` : ''}
          </Link>  
        </div>
      </nav>
      <Modal modalOpen={modalOpen} action={action}  />
    </header>
  )
}