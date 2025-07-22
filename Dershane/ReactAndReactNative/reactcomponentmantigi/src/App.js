import "././App.css";
import Navbar, {Second_Navbar} from './components/navbar'
import Govde from './components/body'

function App() {
  return (
    <div className="App">
      <Navbar></Navbar>
      <Second_Navbar></Second_Navbar>
      <Govde></Govde>
    </div>
  );
}

export default App;