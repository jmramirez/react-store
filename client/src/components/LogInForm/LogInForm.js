import './LogInForm.scss'
import { useDispatch, useSelector} from "react-redux";
import {hideAuthModal} from "../../redux/actions/modalActions";
import { useForm } from "react-hook-form";
import { login } from "../../redux/actions/userActions";
import {useEffect} from "react";

const LoginForm = () => {
    const  { register, handleSubmit, reset } = useForm({ defaultValues: { email: "", password: ""}})
    const dispatch = useDispatch()
    
    const userLogin = useSelector((state) => state.userLogin)
    const { loading, error, userInfo } = userLogin
    
    useEffect(() => {
        if(userInfo) {
            reset()
        }
    }, [userInfo])
    
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
            {error && <p>{error}</p>}
            <form className="form" onSubmit={handleSubmit(onSubmit)}>
                <div className="form-content">
                    <h1 className="form-content__header">Log In</h1>
                    <label className="form-content__label">
                        Username/Email
                    </label>
                    <input className="form-content__input" type="text" {...register("email")} autoComplete="off"/>
                    <label className="form-content__label">
                        Password
                    </label>
                    <input type="password" className="form-content__input" {...register("password")}/>
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