import './CartPage.scss'
import {CarList} from '../../components/CartList/CarList'

export  const CartPage = (history) => {
  return(
    <section className="shoppingCart">
      <h2 className="shoppingCart__heading">ShoppingCart</h2>
      <div className="shoppingCart__container">
        <CarList />
      </div>
    </section>
  )
}