export const server = 
        process.env.REACT_APP_ENV === 'production' 
        ? 'https://reactstore21-backend.azurewebsites.net'
        : process.env.REACT_APP_ENV === 'staging'
        ? 'https://reactstore21-backend-staging.azurewebsites.net'
        : 'https://localhost:5003';


    export const webAPIURL = `${server}/api`;

    
        
