# CoreStoreNet

The idea for this application is to create an e-commerce application, using an ASP.NET Core web API and React.js Single-Page Application (SPA) frontend.

## Backend

The web API is developed using a multiyear architecture, including data access, domain, and HTTP layer.

**`Data access:`** necessary to store information in a database, in this case Entity Framework is used as ORM, and the repository pattern is used as an additional abstraction over the data source. Additionally, a separation between saving operation and reading/writing operations is made using the unit of work approach, so the repository allows higher layers to perform get, create, and update operations on memory collections, while unit of work implements a way to transfer those changes to the database.

**`Data model:`** is the representation of the data handled by the API including entities, data transfer objects (Dtos), as well as all the application logic using the service classNames approach.

**`HTTP layer:`** includes the action methods that handle all the call requests to the service layer built in the domain project and send the response.

## Frontend

Frontend consists of a single page application made using react.js, sass for styling, and redux to manage state of the shopping cart as well as authentication token.

## Stripe

The application uses Stripe gateway in order to allow users to complete their purchases and process their payment information.

## Checkout Process

To initiate the checkout process, the user needs to be registered in the system, a demo account has been created for testing purposes.

Once the user has logged in, and filled the information required, name, address, country, postal code, the payment details for the **`Stripe API`** to work, are **`any name`**, and **`4242 4242 4242 4242`** as credit card number, a future date, and any CVC and ZIP code.

### Link to App: [https://corestorenet.com/](https://corestorenet.com/) 
