import './CheckoutPage.scss'
import CheckoutForm from "../../components/CheckoutForm/CheckoutForm";
import {loadStripe} from "@stripe/stripe-js";
import {Elements} from "@stripe/react-stripe-js";

export const CheckoutPage = () => {
    const stripe = loadStripe('pk_test_51JSqRkHyqUWXkZvhkJrM0cWerW3BjJ4IBhbcKqa4Sz7CoT3HouLB6EPCAGbFg3cvtRkpDT5NhksuZHfQepcnXKIo00U2xnWNp7')
    
    return(
        <section className="checkout">
            <h2 className="checkout__heading">Checkout</h2>
            <div className="checkout__container">
                <div className="checkout__container-form">
                    <Elements stripe={stripe}>
                        <CheckoutForm/>
                    </Elements>
                </div>
            </div>
        </section>
    )
}