import {
    SHOW_AUTH_MODAL,
    HIDE_AUTH_MODAL
} from '../constants/modalConstant'

export const showAuthModal = () => async(dispatch, getState) => {
    dispatch({
        type: SHOW_AUTH_MODAL
    })
}

export const hideAuthModal = () => async(dispatch, getState) => {
    dispatch({
        type: HIDE_AUTH_MODAL
    })
}