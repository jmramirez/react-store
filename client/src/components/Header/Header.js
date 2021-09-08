import './Header.scss'
import { Link, useHistory } from 'react-router-dom'
import { useSelector} from 'react-redux'
import {useEffect, useState} from 'react'
import Modal from "../Modal/Modal";
import { useDispatch } from "react-redux";
import { showAuthModal,  } from "../../redux/actions/modalActions";
import { logout } from "../../redux/actions/userActions";
import axios from "axios";


export const Header = () => {
  const items = useSelector((state) => state.cart.cartItems)
  const modalOpen = useSelector((state) => state.modal.showAuthModal)
  const action = useSelector((state) => state.modal.actionForm)
  const [totalItems, setTotalItems] = useState(0)
  const dispatch = useDispatch()
  const history = useHistory()

  const userLogin = useSelector((state) => state.userLogin)
  const { userInfo, token } = userLogin
  
  useEffect(() => {
    const reducer = (accumulator, cartItem) => accumulator + cartItem.quantity;
    const totalItems = items.reduce(reducer, 0)
    setTotalItems(totalItems)
  }, [items])
  
  useEffect(() => {
    if(userInfo)
      axios.defaults.headers.common["Authorization"] = `Bearer ${token}`
  }, [])
  
  const openModal = (action) => {
    dispatch(showAuthModal(action))
  }
  
  
   
  
  const userLogout = () => {
    dispatch(logout())
    history.push('/')
  }
  
  
  return (
    <header className="header">
      <nav className="header-nav">
        <Link to="/" className="header-nav__heading">
          CoreNETStore
        </Link>
        <div className="header-nav__links">
          {
            userInfo ? 
                <div className="header-nav__links-auth">
                  Hello, {userInfo.fullName}
                  <div className="header-nav__links-auth__test header-nav__links-auth__test--user">
                    <button className="header-nav__links-auth__test__auth-sign" onClick={() => openModal('signin')}>
                      Your Account
                    </button>
                    <button className="header-nav__links-auth__test__auth-create" onClick={userLogout}>
                      Log Out
                    </button>
                  </div>
                </div>
                :(
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
                )
          }
          <Link to="/cart" className="header-nav__shoppingCart">
            <span className="material-icons header-nav__shoppingCart__icon">shopping_cart</span>
            {totalItems ? `(${totalItems} Items)` : ''}
          </Link>  
        </div>
      </nav>
      <Modal modalOpen={modalOpen} action={action}  openSignUpForm={openModal}/>
    </header>
  )
}