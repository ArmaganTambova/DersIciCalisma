import Axios from 'axios';
import React, {useState, useEffect} from 'react'

function App() {

  const [data, setData] = useState("");
  const [id, setID] = useState(0);

  useEffect(()=> {
    Axios.get("https://jsonplaceholder.typicode.com/posts")
    .then(res => setData(res.data[id].title))
    .catch(err => console.error(err));
  }, [data, id]);

  return (
    <div className="App">
      <p>{data}</p>
      <input type='text' value={id} onChange={E => setID(E.target.value)}></input>
    </div>
  );
}

export default App;
