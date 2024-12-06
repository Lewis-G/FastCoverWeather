import { useState } from 'react';

const HomePage = () => {
  const [searchInput, setSearchInput] = useState('');
  const [addedCities, setAddedCities] = useState([]);

  const handleSearchChange = (e) => {
    setSearchInput(e.target.value);
  };

  const handleAddCity = () => {
    if (searchInput && !addedCities.includes(searchInput)) {
      setAddedCities([...addedCities, searchInput]);
      setSearchInput(''); // Clear the input after adding
    }
  };

  return (
    <div className="container mt-4">
      {/* Search Bar */}
      <div className="input-group mb-3">
        <input
          type="text"
          className="form-control"
          placeholder="Enter city name"
          value={searchInput}
          onChange={handleSearchChange}
        />
        <button
          className="btn btn-primary"
          type="button"
          onClick={handleAddCity}
        >
          Add
        </button>
      </div>

      {/* Display Added Cities */}
      <div>
        <h5>Added Cities:</h5>
        <ul>
          {addedCities.map((city, index) => (
            <li key={index}>{city}</li>
          ))}
        </ul>
      </div>
    </div>
  );
};

export default HomePage;
