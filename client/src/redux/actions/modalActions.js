import {
    SHOW_AUTH_MODAL,
    HIDE_AUTH_MODAL
} from '../constants/modalConstant'

import {
    CLEAR_LOGIN_FAIL
} from "../constants/userContanst";

export const showAuthModal = () => async(dispatch, getState) => {
    dispatch({
        type: SHOW_AUTH_MODAL
    })
}

export const hideAuthModal = () => async(dispatch, getState) => {
    dispatch({
        type: CLEAR_LOGIN_FAIL
    })
    dispatch({
        type: HIDE_AUTH_MODAL
    })
}