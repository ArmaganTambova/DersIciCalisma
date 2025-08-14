import React, { useEffect, useState } from 'react';
import './App.css';
import Axios from 'axios';
import ListItem from './components/listitem'

function App() {
  const products = [
    { id: 1, name: "Ürün 1", description: "Ürün 1 Açıklaması", price: 159.99 },
    { id: 2, name: "Ürün 2", description: "Ürün 2 Açıklaması", price: 99.99 },
    { id: 3, name: "Ürün 3", description: "Ürün 3 Açıklaması", price: 49.99 },
    { id: 4, name: "Ürün 4", description: "Ürün 4 Açıklaması", price: 29.99 },
    { id: 5, name: "Ürün 5", description: "Ürün 5 Açıklaması", price: 19.99 },
    { id: 6, name: "Ürün 6", description: "Ürün 6 Açıklaması", price: 9.99 },
    { id: 7, name: "Ürün 7", description: "Ürün 7 Açıklaması", price: 5.99 },
    { id: 8, name: "Ürün 8", description: "Ürün 8 Açıklaması", price: 2.99 },
    { id: 9, name: "Ürün 9", description: "Ürün 9 Açıklaması", price: 1.99 },
    { id: 10, name: "Ürün 10", description: "Ürün 10 Açıklaması", price: 0.99 }
  ]

  const [veriler, setData] = useState([]);

  const imgUrl = "https://placehold.co/600x400";

  useEffect(()=> {
    Axios.get("https://jsonplaceholder.typicode.com/photos")
      .then(res => setData(res.data))
      .catch(err => console.error(err));
  });

  return (
    <>
    <div className="App">
      <h2>Bizim Veriler</h2>
      {
        products.map((data, i) => (
          <p>Selam</p>
        ))
      }
    </div>

    <div className="App">
      <h2>Json Placeholder Veriler</h2>
      {
        veriler.map((data, i) => (
          <ListItem baslik={data.title} resim={imgUrl} />
        ))
      }
    </div>
    </>
  );
}

export default App;
