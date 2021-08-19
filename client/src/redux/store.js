import { createStore, combineReducers,applyMiddleware } from 'redux'
import thunk from 'redux-thunk'
import { composeWithDevTools} from 'redux-devtools-extension'
import { cartReducer } from './reducers/cartReducers'
import { modalReducers} from "./reducers/modalReducers";

const reducer = combineReducers({
  cart: cartReducer,
  modal: modalReducers
})

const cartItemsFromStorage = localStorage.getItem('cartItems') ? JSON.parse(localStorage.getItem('cartItems')) : []

const initialState = {
  cart: { 
    cartItems: cartItemsFromStorage 
  },
  modal: {
    showAuthModal: false 
  } 
}
const middleware = [thunk]

const store = createStore(reducer, initialState, composeWithDevTools(applyMiddleware(...middleware))
)

export default store