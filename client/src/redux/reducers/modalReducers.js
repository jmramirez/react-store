import {
    SHOW_AUTH_MODAL,
    HIDE_AUTH_MODAL
} from "../constants/modalConstant";

export const modalReducers = (state={ showAuthModal: false}, action) => {
    switch (action.type) {
        case SHOW_AUTH_MODAL:
            return {
                ...state,
                showAuthModal: true
            }
        case HIDE_AUTH_MODAL:
            return {
                ...state,
                showAuthModal: false
            }
        default:
            return state
    }
}