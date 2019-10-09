# Weather API Project
API testing on OpenWeatherAPI - 5 day / 3 hour forecast data

## Table of contents
* [General info](#general-info)
* [Prerequisites](#Prerequisites)
* [Setup](#setup)
* [Running the tests](#Running-the-tests)
* [Developement](#Developement)
* [Built With](#Built-With)

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

## General info
The project was based on OpenWeather API, I have to test the

## Prerequisites
What things you need to install the software and how to install them
```
Postman - Platform for API Developement - https://www.getpostman.com/downloads/
Gitbash - Create or Clone the Repository - https://www.github.com/
Visual Studio - Run the application -- https://visualstudio.microsoft.com/downloads/ 
```

## Setup
A step by step series of examples that tell you how to get a development environment running
```
Step 1: open Visual Studio
Step 2: Create new Project, based on Class Libary or Console APP (both have to be .NET Framework) 
Step 3: Create Two Folder: Tests and Folder Based on API (E.g. OpenWeatherMap_Forecast)
Step 4: Inside Folder Based on API, Create two folder: Data_Handling and HTTP_Maanger
Step 5: Inside Data_Handling Folder, Create two C# File: E.g. OpenWeatherMapDTO.cs and OpenWeatherMapModel.cs
Step 6: Inside HTTP_Folder, Create one C# File: E.g. OpenWeatherMapCallManager.cs
Step 7: Inside OpenWeatherMap_Forecast Folder, Create one C# File E.g. OpenWeatherMapService.cs
Step 8: Inside Tests Folder, Create one C# File: E.g. OpenWeatherMapTest.cs
Step 9: Create two C# File on Package: E.g. App.config and OpenWeatherMapConfig.cs
Step 10: Right click on Reference then Add Reference then Assembiles option and look for System.Configuration (make sure to tick the box and press ok)
step 11: Right click on Package then select Manage Nuget Packages then click on browse and install Nunit, Nunit3TestAdapter, Newtonsoft.Json and RestSharp
```

## Running the tests

## Developement

## Built With
```
Postman - Platform for API Developement to run the API
Gitbash - create, push, commit and pull Git Repository
Visual Studio - Create the project 
OpenWeather - API for testing
```




