import './Header.scss'
import {Link} from 'react-router-dom'
import { useSelector} from 'react-redux'
import {useEffect, useState} from 'react'
import Modal from "../Modal/Modal";

export const Header = ({handleOpenModal, modalOpen}) => {
  const items = useSelector((state) => state.cart.cartItems)
  const [totalItems, setTotalItems] = useState(0)
  
  useEffect(() => {
    const reducer = (accumulator, cartItem) => accumulator + cartItem.quantity;
    const totalItems = items.reduce(reducer, 0)
    setTotalItems(totalItems)
  }, [items])
  
  
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
              <button className="header-nav__links-auth__test__auth-sign">
                Sign In
              </button>
              <button className="header-nav__links-auth__test__auth-create" onClick={handleOpenModal}>
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
      <Modal modalOpen={modalOpen} handleOpenModal={handleOpenModal} />
    </header>
  )
}