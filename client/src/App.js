
import './App.scss';
import {Product} from "./components/Product/Product";
import {Header} from "./components/Header/Header";
import {ProductsList} from "./components/ProductsList/ProductsList";

function App() {
  return (
    <div className="App">
      <Header />
        <ProductsList/>
    </div>
  );
}

export default App;
