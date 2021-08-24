import './RegisterForm.scss'
import {useForm} from "react-hook-form";
import {useDispatch} from "react-redux";
import { hideAuthModal } from "../../redux/actions/modalActions";
import {value} from "lodash/seq";
import {useRef} from "react";

const RegisterForm = () => {
    const { register, handleSubmit, reset, formState: { errors }, watch } = useForm({ defaultValues: { }})
    const dispatch = useDispatch()
    const password = useRef({})
    password.current = watch("password", "")
    
    const closeModal = (e) => {
        e.preventDefault()
        reset()
        dispatch(hideAuthModal())
    }
    
    return(
        <>
            <form className="form--xl">
                <div className="form-content">
                    <h1 className="form-content__header">Sign Up</h1>
                    <div className="form-content__name">
                        <div className="form-content__name__controls">
                            <label className="form-content__label">First Name</label>
                            <input type="text" className="form-content__input" autoComplete="off" {...register("firstName")}/>
                            {errors.email &&( <p className="form__error">You must enter FirstName</p>)}
                        </div>
                        <div className="form-content__name__controls">
                            <label className="form-content__label">Last Name</label>
                            <input type="text" className="form-content__input" autoComplete="off" {...register("lastName")}/>
                            {errors.email &&( <p className="form__error">You must enter LastName</p>)}
                        </div>
                    </div>
                    <label className="form-content__label">Email</label>
                    <input type="text" className="form-content__input" autoComplete="off" {...register("email")}/>
                    {errors.email &&( <p className="form__error">You must enter email</p>)}
                    <label className="form-content__label">Password</label>
                    <input type="text" className="form-content__input" autoComplete="off"  {...register("password")}/>
                    {errors.email &&( <p className="form__error">You must enter password</p>)}
                    <label className="form-content__label">Confirm Password</label>
                    <input type="text" className="form-content__input" autoComplete="off" {...register("passwordConfirmation", {validate: value => value === password.current || "The passwords do not match"})}/>
                    {errors.password &&( <p className="form__error">You must confirm password</p>)}
                </div>
                <div className="form-action">
                    <button className="form-action__cancel" onClick={closeModal}>
                        Cancel
                    </button>
                    <input className="form-action__accept" type="submit" value="Join Now" />
                </div>
            </form>
        </>
    )
}

export default  RegisterForm