import './Modal.scss'

const Modal = ({ modalOpen, handleOpenModal }) => {
    return(
        <div className={ modalOpen ? 'modal--open' : 'modal'}>
            <div className="modal-background"></div>
            <div className="modal-body">
                <div className="modal-content">
                    <button className="modal__close-button" onClick={handleOpenModal}><span className="modal__close-icon"></span></button>
                    <h1 className="modal-content__header"> This is a modal</h1>
                </div>
            </div>
        </div>
    )
}

export default Modal;