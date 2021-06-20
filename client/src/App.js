import './App.scss';
import {BrowserRouter, Switch, Route} from 'react-router-dom'
import {CatalogPage} from './pages/CatalogPage/CatalogPage'
import {ProductPage} from './pages/ProductPage/ProductPage'
import {Header} from './components/Header/Header'

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Header />
        <Switch>
          <Route path='/' exact render={(props) => <CatalogPage {...props} />} />
          <Route path='/products' render={(props) => <CatalogPage {...props} />} />
        </Switch>
      </BrowserRouter>
    </div>
  );
}

export default App;
