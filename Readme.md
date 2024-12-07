# FastCoverWeather

Steps to view the UI:
1. Git clone this repository
2. Run 'npm run dev' in the ;FastCoverWeather.Frontend' directory
3. Go to 'http://localhost:5173/' to view the web page

Next steps would be:
1. Develop a basic weather controller on the .NET Web API backend, upon receiving longitude and latitude params, it would query the open-meteo weather API. See an example below.
2. Send axios HTTP requests from the frontend to the backend, upon a new city being selected. This request would contain the city name, longitude, and latitude.
3. Receive the response from the backend, and render the relevant weather data.
4. Host the frontend and backend on a site on render.com so that it is publicly available. 

open-meteo request
```
curl --location 'https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&hourly=temperature_2m'
```