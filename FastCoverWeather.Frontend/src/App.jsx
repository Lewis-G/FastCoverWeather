import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import { useState } from 'react';
import NavBar from './components/NavBar';
import HomePage from './pages/HomePage';
import CityPage from './pages/CityPage';

function App() {
  const [myCities, setMyCities] = useState([]);

  const addCity = (city) => {
    let i = 0;
    while (i < myCities.length){
      if (myCities[i] == city){
        return;
      }
      i++;
    }
    setMyCities((prevCities) => [...prevCities, city]);
  };

  return (
    <Router>
      <div
        style={{
          backgroundImage: "url(/src/assets/bright-blue-sky-dotted-with-fluffy-white-clouds.jpg)", // Image path from assets folder
          backgroundSize: "cover",
          backgroundPosition: "center",
          minHeight: "100vh",
        }}
      >
        <NavBar />

        <Routes>
          <Route 
            path="/" 
            element={<HomePage myCities={myCities} addCity={addCity} />} 
          />
          <Route path="/city/:cityName" element={<CityPage />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
