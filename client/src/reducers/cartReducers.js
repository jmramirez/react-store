import { CART_ADD_ITEM } from '../constants/cartConstants'

export const cartReducer = (state = { cartItems:[]}, action) => {
  switch (action.type) {
    case CART_ADD_ITEM:
      const item = action.product
      const index = state.cartItems.findIndex(
        x =>
          x.productId === item.productId &&
          x.colorId === item.colorId &&
          x.storageId === item.storageId
      )
      
      if(index >= 0) {
        const newItems = state.cartItems.slice()
        const cartItem = Object.assign({}, state.cartItems[index])
        cartItem.quantity = cartItem.quantity + 1
        cartItem.subTotal = cartItem.subTotal + cartItem.price
        newItems.splice(index, 1, cartItem)
        return {
          ...state,
          cartItems: newItems
        }
      } else {
          const quantity = 1
          const subTotal = quantity * item.price
          return {
            ...state,
            cartItems: [...state.cartItems, {...item, quantity, subTotal}]
          }
      }
    default:
      return state
  }
}