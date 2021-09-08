import { useSelector } from "react-redux";
import { Component } from "react";
import { Route, Redirect } from "react-router-dom";

export const PrivateRoute = ({ component: Component, ...rest }) => {
    const userLogin = useSelector((state) => state.userLogin)
    const { userInfo } = userLogin
    
    return(
        <Route {...rest} render={props =>(
          userInfo?(
              <Component {...props} />
          ) : (
              <Redirect to={{
                  pathname: '/cart',
                  state: { from: props.location}
              }}/>
          )  
        )}/>
    )
}