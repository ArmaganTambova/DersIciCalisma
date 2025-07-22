import { useState } from 'react';
import './App.css';
import Container from './components/container';

function App() {
  const [baslik, setBaslik] = useState("Nedir Bu Propslar?");
  const altaciklama = "C#'ın Metot Propertylerine Benzer Bir Kullanımdır.";

  return (
    <div className="App">
      <Container deneme={baslik} aciklama={altaciklama}></Container>

      <button onClick={()=> {setBaslik("Buton Aracılığıya Değiştirdim.")}}>Prop İçeriği Değiştir</button>
    </div>
  );
}

export default App;
