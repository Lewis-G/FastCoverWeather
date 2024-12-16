import { useState } from 'react';
import PropTypes from 'prop-types';
import Select from 'react-select';
import citiesData from '../data/cities.json';

const HomePage = ({ myCities, addCity }) => {
  const [selectedCity, setSelectedCity] = useState(null);

  const handleCitySelect = (city) => {
    setSelectedCity(city);

    if (city && !myCities.includes(city.value)) {
      addCity(city.value);
    }
  };

  return (
    <div className="container">
      <h1 style={{ color: 'lightblue', marginTop: '30px', marginBottom: '30px' }}>
        Weather App
      </h1>

      <div className="input-group mb-3">
        <Select
          value={selectedCity}
          onChange={handleCitySelect}
          options={citiesData.cities.map(city => ({ value: city, label: city }))}
          placeholder="Search for a city"
          getOptionLabel={(e) => e.label}
          getOptionValue={(e) => e.value}
        />
      </div>

      {myCities.length > 0 && (
        <div>
          <h3>My Cities</h3>
          <div className="row row-cols-2 row-cols-md-3 row-cols-lg-4 g-4">
            {myCities.map((city, index) => (
              <div className="col" key={index}>
                <div className="card text-center shadow-sm">
                  <div className="card-body">
                    <h5 className="card-title">{city}</h5>
                    <p className="card-text">Additional info here</p> {/* You can add more info here */}
                  </div>
                </div>
              </div>
            ))}
          </div>
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
