import './App.scss';
import {BrowserRouter, Switch, Route} from 'react-router-dom'
import {CatalogPage} from './pages/CatalogPage/CatalogPage'
import {Header} from './components/Header/Header'
import {ProductPage} from './pages/ProductPage/ProductPage'
import {CartPage} from './pages/CartPage/CartPage'
import {useState} from "react";

function App() {
  const [modalOpen, setModalOpen] = useState(false)

  const handleOpenModal = () => {
    setModalOpen(!modalOpen)
  }
  
  return (
    <div className={ modalOpen ? 'App__open' : 'App'}>
      <BrowserRouter>
        <Header modalOpen={modalOpen} handleOpenModal={handleOpenModal}/>
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
