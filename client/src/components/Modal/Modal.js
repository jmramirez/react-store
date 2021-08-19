import './Modal.scss'
import LoginForm from "../LogInForm/LogInForm";

const Modal = ({ modalOpen, handleOpenModal }) => {
    return(
        <div className={ modalOpen ? 'modal--open' : 'modal'}>
            <div className="modal-background"></div>
            <div className="modal-body">
                <button className="modal__close-button" onClick={handleOpenModal}><span className="modal__close-icon"></span></button>
                <LoginForm/>
            </div>
            
        </div>
    )
}

export default Modal;