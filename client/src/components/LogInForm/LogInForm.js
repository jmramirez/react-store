import './LogInForm.scss'
import {useDispatch} from "react-redux";
import {hideAuthModal} from "../../redux/actions/modalActions";

const LoginForm = () => {
    const dispatch = useDispatch()
    
    const closeModal = (e) => {
        e.preventDefault()
        dispatch(hideAuthModal())
    }
    
    return(
        <form className="form">
            <div className="form-content">
                <h1 className="form-content__header">Log In</h1>
                <label className="form-content__label">
                    Username/Email
                </label>
                <input className="form-content__input"/>
                <label className="form-content__label">
                    Password
                </label>
                <input type="password" className="form-content__input"/>
                <button className="form-content__button">Not account? Create one!</button>
            </div>
            <div className="form-action">
                <button className="form-action__cancel" onClick={closeModal}>
                    Cancel
                </button>
                <button>
                    Sign In
                </button>
            </div>
        </form>
    )
}

export default LoginForm