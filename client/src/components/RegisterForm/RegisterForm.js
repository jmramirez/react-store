import './RegisterForm.scss'

const RegisterForm = () => {
    
    const closeModal = (e) => {
        e.preventDefault()
    }
    
    return(
        <>
            <form className="form">
                <div className="form-content">
                    <h1 className="form-content__header">Sign Up</h1>
                    <div className="form-content__name">
                        <div className="form-content__name__controls">
                            <label className="form-content__label">First Name</label>
                            <input type="text" className="form-content__input"/>
                        </div>
                        <div className="form-content__name__controls">
                            <label className="form-content__label">Last Name</label>
                            <input type="text" className="form-content__input"/>
                        </div>
                    </div>
                    <label className="form-content__label">Email</label>
                    <input type="text" className="form-content__input"/>
                    <label className="form-content__label">Password</label>
                    <input type="text" className="form-content__input"/>
                    <label className="form-content__label">Confirm Password</label>
                    <input type="text" className="form-content__input"/>
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

export default  RegisterForm