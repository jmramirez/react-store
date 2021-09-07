import './CheckoutForm.scss'
import {CardElement, Elements, useElements, useStripe} from "@stripe/react-stripe-js";
import { useSelector } from "react-redux";
import {useEffect, useState} from "react";
import {CartSummary} from "../CartSummary/CartSummary";
import {useForm} from "react-hook-form";



const CheckoutForm = () => {
    const { register, handleSubmit, reset, formState: { errors }} = useForm()
    const items = useSelector((state) => state.cart.cartItems)
    const [subTotal, setSubTotal] = useState(0)
    const stripe = useStripe()
    const elements = useElements()
    
    useEffect(() => {
        const reducer = (accumulator, cartItem) => accumulator + cartItem.subTotal;
        const total = items.reduce(reducer,0)
        setSubTotal(total)
    }, [])
    
    
    const onSubmit = async (data, e) => {
        try {
            e.preventDefault()
            const payload = await stripe.createPaymentMethod({
                type: "card",
                card: elements.getElement(CardElement)
            })
            console.log(payload)   
        } catch (e) {
            console.log(e)
        }
    }
    
    return (
        <>
            <form className="form--checkout" onSubmit={handleSubmit(onSubmit)}>
                <div className="form-content form-content--checkout">
                    <h3 className="form-content__header--md">Delivery Address</h3>
                    <label className="form-content__label">First Name</label>
                    <input className="form-content__input"/>
                    <label className="form-content__label">Last Name</label>
                    <input className="form-content__input"/>
                    <label className="form-content__label">Address</label>
                    <input className="form-content__input"/>
                    <label className="form-content__label">Address 2</label>
                    <input className="form-content__input"/>
                    <label className="form-content__label">Town / City</label>
                    <input className="form-content__input"/>
                    <label className="form-content__label">Country</label>
                    <input className="form-content__input"/>
                    <label className="form-content__label">Postal Code</label>
                    <input className="form-content__input"/>
                    <h3 className="form-content__header--md">Payment Details</h3>
                    <label className="form-content__label">Name on Card</label>
                    <input className="form-content__input"/>
                    <label className="form-content__label">Credit/debit card details</label>
                    <CardElement
                        options={{
                            style: {
                                base: {
                                    fontSize: '16px',
                                    color: '#424770',
                                    '::placeholder': {
                                        color: '#323232',
                                    },
                                    lineHeight: '24px',
                                },
                                invalid: {
                                    color: '#9e2146',
                                },
                            },
                        }}
                    />
                    <input type="submit" value="Place your order" className="form--checkout__action"/>
                </div>
                <div className="form-content form-content--summary">
                    <h3 className="form-content__header--md">Your Cart</h3>
                    <ul>
                        <CartSummary items={items} />
                        <li className="form--checkout__total">
                            Total: ${subTotal}
                        </li>
                    </ul>
                </div>
            </form>
        </>
    )
}

export default CheckoutForm;