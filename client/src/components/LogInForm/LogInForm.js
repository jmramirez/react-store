import './LogInForm.scss'
import { useDispatch, useSelector} from "react-redux";
import {hideAuthModal} from "../../redux/actions/modalActions";
import { useForm } from "react-hook-form";
import { login } from "../../redux/actions/userActions";
import {useEffect} from "react";

const LoginForm = () => {
    const  { register, handleSubmit, reset, formState: { errors } } = useForm({ defaultValues: { email: "", password: ""}})
    const dispatch = useDispatch()
    
    const modalOpen = useSelector((state) => state.modal.showAuthModal)
    const userLogin = useSelector((state) => state.userLogin)
    const { loading, error, userInfo } = userLogin
    
    useEffect(() => {
        if(!modalOpen) {
            reset()
        }
    }, [modalOpen])
    
    const closeModal = (e) => {
        e.preventDefault()
        reset()
        dispatch(hideAuthModal())
        
    }
    
    const onSubmit = (data, e) => {
        e.preventDefault()
        console.log(data,e)
        dispatch(login(data.email, data.password))
    }
    
    return(
        <>
            <form className="form" onSubmit={handleSubmit(onSubmit)}>
                <div className="form-content">
                    <h1 className="form-content__header">Sign In</h1>
                    {error && <p className="form__error">{error}</p>}
                    <label className="form-content__label">
                        Username/Email
                    </label>
                    <input className="form-content__input" type="text" {...register("email", { required: true })} autoComplete="off"/>
                    {errors.email &&( <p className="form__error">You must enter username</p>)}
                    <label className="form-content__label">
                        Password
                    </label>
                    <input type="password" className="form-content__input" {...register("password", { required: true })}/>
                    {errors.password &&( <p className="form__error">You must enter password</p>)}
                    <button className="form-content__button">Not account? Create one!</button>
                </div>
                <div className="form-action">
                    <button className="form-action__cancel" onClick={closeModal}>
                        Cancel
                    </button>
                    <input className="form-action__accept" type="submit" value="Log In" />
                </div>
            </form>
        </>
    )
}

export default LoginForm