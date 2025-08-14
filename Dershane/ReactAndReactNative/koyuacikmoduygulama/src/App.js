import React, { useState } from 'react';
import './App.css';
import Container from './components/container';

const Thema = {
  dark:{
    color: "white",
    backgroundColor: "black",
  },
  light:{
    color: "black",
    backgroundColor: "white",
  }
}
export const ThemaData = React.createContext();

function App() {

  const [Data, setData] = useState(Thema.dark);

  function temaDegistir() {
    if (Thema.dark === Data) {
      setData(Thema.light);
    }
    else {
      setData(Thema.dark);
    }
  }

  return (
    <div className="App">
      <button onClick={temaDegistir}>{Thema.dark === Data? "Açık Tema":"Koyu Tema"}</button>

      <ThemaData.Provider value={Data}>
        <Container></Container>
      </ThemaData.Provider>
    </div>
  );
}

export default App;
