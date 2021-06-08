import './App.scss';
import {BrowserRouter, Switch, Route} from 'react-router-dom'
import {CataloguePage} from './pages/CataloguePage/CataloguePage'
import {ProductPage} from './pages/ProductPage/ProductPage'
import {Header} from './components/Header/Header'

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Header />
        <Switch>
          <Route path='/' component={CataloguePage} />
          <Route path='/products' component={ProductPage} />
        </Switch>
      </BrowserRouter>
    </div>
  );
}

export default App;
