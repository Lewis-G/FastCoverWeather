import { useState } from 'react';
import PropTypes from 'prop-types';
import citiesData from '../data/cities.json';

const HomePage = ({ myCities, addCity }) => {
  const [searchQuery, setSearchQuery] = useState('');
  const [suggestions, setSuggestions] = useState([]);

  const handleSearch = (event) => {
    const query = event.target.value;
    setSearchQuery(query);

    if (query) {
      const filteredCities = citiesData.cities.filter(city =>
        city.name.toLowerCase().startsWith(query.toLowerCase())
      );
      setSuggestions(filteredCities);
    } else {
      setSuggestions([]);
    }
  };

  const handleCitySelect = (city) => {
    setSearchQuery(city.name);
    setSuggestions([]);
  };

  const handleAddCity = () => {
    if (searchQuery && !myCities.some(city => city.name === searchQuery)) {
        addCity(searchQuery);
    }
    setSearchQuery('');
  };

  return (
    <div className="container">
      <h1 style={{ color: 'lightblue' }}>Weather App</h1>

      <div className="input-group mb-3">
        <input
          type="text"
          className="form-control"
          placeholder="Search for a city"
          value={searchQuery}
          onChange={handleSearch}
        />
        <button className="btn btn-primary" onClick={handleAddCity}>Add</button>
      </div>

      {suggestions.length > 0 && (
        <ul className="list-group">
          {suggestions.map((city) => (
            <li
              key={city.name}
              className="list-group-item list-group-item-action"
              onClick={() => handleCitySelect(city)}
            >
              {city.name}
            </li>
          ))}
        </ul>
      )}

      {myCities.length > 0 && (
        <div>
          <h3>My Cities</h3>
          <ul>
            {myCities.map((city, index) => (
              <li key={index}>{city.name}</li>
            ))}
          </ul>
        </div>
      )}
    </div>
  );
};

HomePage.propTypes = {
  myCities: PropTypes.array.isRequired,
  addCity: PropTypes.func.isRequired
};

export default HomePage;
