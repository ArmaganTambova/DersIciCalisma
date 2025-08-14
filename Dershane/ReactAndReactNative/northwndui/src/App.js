/*general*/
import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router';

/*pages*/
import Layout from './pages/layout';
import Home from './pages/home';
import Categories from './pages/categories';
import Products from './pages/products';
import PageNotFound from './pages/pagenotfound';

/*style*/
import './App.css';

/********************************************/

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Layout />} >
            <Route index element={<Home />} />
            <Route path="/categories" element={<Categories />} />
            <Route path="/products" element={<Products />} />
            <Route path="*" element={<PageNotFound/>} />
          </Route>
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;