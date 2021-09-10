import './CheckoutPage.scss'
import CheckoutForm from "../../components/CheckoutForm/CheckoutForm";
import {loadStripe} from "@stripe/stripe-js";
import {Elements} from "@stripe/react-stripe-js";
import {useSelector} from "react-redux";
import {useEffect, useState} from "react";
import {Redirect} from "react-router-dom";

export const CheckoutPage = () => {
    const stripe = loadStripe('pk_test_51JSqRkHyqUWXkZvhkJrM0cWerW3BjJ4IBhbcKqa4Sz7CoT3HouLB6EPCAGbFg3cvtRkpDT5NhksuZHfQepcnXKIo00U2xnWNp7')
    const items = useSelector((state) => state.cart.cartItems)
    const [redirectToCart, setRedirectToCart] = useState(false) 
    
    
    useEffect(() =>{
        if(!items.length) {
            setRedirectToCart(true)
        }
    }, [])
    
    if(redirectToCart) {
        return <Redirect to='/cart' />
    }
    
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