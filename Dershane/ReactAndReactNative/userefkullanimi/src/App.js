import React, { useRef, useState } from 'react';
import './App.css';

function App() {
  const [color, setColor] = useState("blue");

  const changedColor = useRef(null);

  const changeColor =()=> {
    document.body.style.backgroundColor = changedColor.current.value;
    setColor(()=> changedColor.current.value);
  };

  return (
    <div className="App">
      <p>Renk Adını İngilizce Giriniz</p>

      <input type='text' ref={changedColor} onChange={changeColor}></input>
    </div>
  );
}

export default App;
