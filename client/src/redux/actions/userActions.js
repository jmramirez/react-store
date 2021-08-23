import axios from "axios";
import {
    USER_LOGIN_SUCCESS,
    USER_LOGIN_REQUEST,
    USER_LOGOUT,
    USER_LOGIN_FAIL
} from "../constants/userContanst";

import {
    HIDE_AUTH_MODAL
} from "../constants/modalConstant";

export const login = (email, password) => async (dispatch) => {
    try {
        dispatch({
            type: USER_LOGIN_REQUEST
        })
        
        const config = {
            headers: {
                'Content-Type': 'application/json'
            }
        }
        
        const { data } = await axios.post(
            'https://localhost:5001/api/user/auth',
            { email, password },
            config
        )
        
        dispatch({
            type: USER_LOGIN_SUCCESS,
            payload: data,
        })
        localStorage.setItem('userInfo', JSON.stringify(data))
        dispatch({
            type: HIDE_AUTH_MODAL
        })
    } catch (error) {
        dispatch({
            type: USER_LOGIN_FAIL,
            payload:
                error.response && error.response.data.message ?
                    error.response.data.message : error.message
        })
    }
}