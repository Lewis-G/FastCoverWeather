import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import NavBar from './components/NavBar';
import HomePage from './pages/HomePage';
import CityPage from './pages/CityPage';

function App() {
  return (
    <Router>
      <div>
        {/* Common Navigation Bar */}
        <NavBar />

        {/* Routes */}
        <Routes>
          <Route path="/" element={<HomePage />} />
          <Route path="/city/:cityName" element={<CityPage />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
