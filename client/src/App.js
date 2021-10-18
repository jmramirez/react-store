import './App.scss';
import {BrowserRouter, Switch, Route} from 'react-router-dom'
import {CatalogPage} from './pages/CatalogPage/CatalogPage'
import {Header} from './components/Header/Header'
import {ProductPage} from './pages/ProductPage/ProductPage'
import {CartPage} from './pages/CartPage/CartPage'
import { useSelector } from "react-redux";
import {CheckoutPage} from "./pages/CheckoutPage/CheckoutPage";
import {PrivateRoute} from "./components/PrivateRoute/PrivateRoute";

function App() {
  const modalOpen = useSelector((state) => state.modal.showAuthModal) 

  
  return (
    <div className={ modalOpen ? 'App__open' : 'App'}>
      <BrowserRouter>
        <Header modalOpen={modalOpen} />
        <Switch>
          <Route path='/' exact render={(props) => <CatalogPage {...props} />} />
          <Route path='/products/:productSlug' render={(props) => <ProductPage {...props} />} />
          <Route path='/products' render={(props) => <CatalogPage {...props} />} />
          <Route path='/cart' render={(props) => <CartPage {...props} />}/>
          <PrivateRoute path='/checkout' component={CheckoutPage} />
        </Switch>
      </BrowserRouter>
    </div>
  );
}

export default App;
