import './Modal.scss'
import LoginForm from "../LogInForm/LogInForm";
import {useDispatch} from "react-redux";
import {hideAuthModal, showAuthModal} from "../../redux/actions/modalActions";
import RegisterForm from "../RegisterForm/RegisterForm";

const Modal = ({ modalOpen, action, openSignUpForm }) => {
    const dispatch = useDispatch() 
    
    const closeModal = () => {
        dispatch(hideAuthModal())
    }
    
    const openModal = () => {
        dispatch(showAuthModal())
    }
    
    return(
        <div className={ modalOpen ? 'modal--open' : 'modal'}>
            <div className="modal-background"></div>
            <div className={`modal-body ${action === 'signup'?' modal-body--xl':'' }`}>
                <button className="modal__close-button" onClick={closeModal}><span className="modal__close-icon"></span></button>
                {action === 'signin' && <LoginForm handleModal={openModal} signUp={openSignUpForm}/>}
                {action === 'signup' && <RegisterForm />}
            </div>
            
        </div>
    )
}

export default Modal;