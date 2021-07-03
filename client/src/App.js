import './App.scss';
import {BrowserRouter, Switch, Route} from 'react-router-dom'
import {CatalogPage} from './pages/CatalogPage/CatalogPage'
import {Header} from './components/Header/Header'
import {ProductPage} from './pages/ProductPage/ProductPage'
import {CartPage} from './pages/CartPage/CartPage'

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Header />
        <Switch>
          <Route path='/' exact render={(props) => <CatalogPage {...props} />} />
          <Route path='/products/:productSlug' render={(props) => <ProductPage {...props} />} />
          <Route path='/products' render={(props) => <CatalogPage {...props} />} />
          <Route path='/cart' render={(props) => <CartPage {...props} />}/>
        </Switch>
      </BrowserRouter>
    </div>
  );
}

export default App;
