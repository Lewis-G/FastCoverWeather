import { useParams } from 'react-router-dom';

const CityPage = () => {
  const { cityName } = useParams();

  return (
    <div className="container mt-4">
      <h2>Weather Details for {cityName}</h2>
      <p>This page will display weather information for {cityName}.</p>
    </div>
  );
};

export default CityPage;
