import { CART_ADD_ITEM} from '../constants/cartConstants'

export const addToCart = (item) => async (dispatch, getState) => {
  dispatch({
    type: CART_ADD_ITEM,
    product: item
  })
  
  localStorage.setItem('cartItems', JSON.stringify(getState().cart.cartItems))
}