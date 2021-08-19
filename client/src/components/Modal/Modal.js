import './Modal.scss'
import LoginForm from "../LogInForm/LogInForm";
import {useDispatch} from "react-redux";
import {hideAuthModal, showAuthModal} from "../../redux/actions/modalActions";

const Modal = ({ modalOpen }) => {
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
            <div className="modal-body">
                <button className="modal__close-button" onClick={closeModal}><span className="modal__close-icon"></span></button>
                <LoginForm handleModal={openModal}/>
            </div>
            
        </div>
    )
}

export default Modal;