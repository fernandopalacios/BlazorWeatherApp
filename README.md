# BlazorWeatherApp
## Overview
This project is a Blazor WebAssembly application built with .NET. Blazor enables the development of interactive web applications using C# and .NET, running entirely in the browser via WebAssembly (or on the server using Blazor Server). 
This app sends requests to weatherapi, documentation for which you'll be able to find here: [WeatherAPI](https://www.weatherapi.com/). All information regarding weather and location comes from here.
The application also requires [WeatherAPI](https://github.com/fernandopalacios/WeatherApi/tree/dev/v1) to work. Be sure to have it installed and running or else, you won't be able to use it.

## Features
- Authentication using a simple Login request, where a Username and a PIN is provided
- Request weather information from different locations across the globe
- CRUD operations for managing locations liked by the User

## Technologies
- .NET 9
- Blazor WebAssembly: Client-side rendering using WebAssembly
- Component-based UI with Razor Components
- Routing and navigation
- Authentication
- Bootstrap for UI design

## Prerequisites
Before running this project, make sure you have installed
- .NET SDK
- A modern web browser like Chrome, Firefox, Edge, etc.
- Visual Studio (or Visual Studio Code with C# extensions)
Also, as mentioned before, you will need to have running the WeatherAPI, preferably in http://localhost:5073

## Installation
1. Clone repository:
```
git clone repository https://github.com/fernandopalacios/WeatherApi.git
```
2. Install the dependencies
```
dotnet restore
```

3. Run the Application
```
dotnet run
```

## Authentication
No JWT is required, only that you provide a Username and PIN. Two users have been preloaded into the API, just for testing:
| Username  | PIN   | 
|-----------|-------|
| lpalacios | 93024 |
| jperez    | 76253 |