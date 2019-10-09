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
The project was based on OpenWeather API, I have to test which matches the data with the data gathered from API through Postman as JSON. 
first i have install specific software for this project (prerequisites section) then setup developement environment (setup section) 
then write code for project developement (developement section) then write test on data, based on the API.

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
Step 0: Create account on OpenWeatherAPI to get key 
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
Step 12: Use API with API key (check Step 0) on Postman to get the data as JSON
```

## Running the tests
one of example of running the tests to check the ID for the rain. On Postman, Rain ID was 501 and this test will check all the 
rain ID through the list, if the ID matches then it will pass the test but if the ID doesn't match then test fails.
```C#
       [Test]
        public void OpenWeatherMapListWeatherID()
        {
            //list for ID rain 
            var id = new List<int>();
            id.AddRange(new[] { 500, 501, 502, 503, 504, 511, 520, 521, 522, 531 });

            Assert.Contains(openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].weather[0].id, id);
        }
```

Another example, compare the tempature with tempature max to see both of them have same value, if both have same value 
then test passed however if the value doesn't match then test fails. 
```C#
        [Test]
        public void OpenWeatherMapListTempCompare()
        {
            //compare Temp with Temp Max
            double temp = openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].main.temp;
            double tempmax = openWeatherMapForcast.openWeatherMapDTO.openWeatherMap.list[0].main.temp_max;
            Assert.AreEqual(temp, tempmax);
        }
```

## Developement
once the environment is setup (check setup content), and next step is develop the project to connect the API then test the API data
```
App.Config file - call the API through APP settings section (current application's default configuration) with base_url, API_ City, API_key property.  

OpenWeatherMapConfig.cs - use system.configuration and call the command configuationManager to use APP settings property.

OpenWeatherMapTest.cs - to write tests.

OpenWeatherMapService.cs - we need to call DTO C# file, Call Manager C# file, JSON Object (using JSON nuGet package), 
write a public method to parse JSON Object (load a Jobject from string that contain JSON) and 
call DeserializeOpenWeatherMap method from OpenWeatherMapDTO file.

OpenWeatherMapDTO.cs - write a public method to call OpenWeatherMapModel.cs file and DeserializeOpenWeatherMap to call the command
JsonConvert.DeserializeObject (converting between .Net types and JSON types then Deserialize the JSON
to specific .NET type). 

OpenWeatherMapModel.cs  - Model objects retrieve and store model state in the persistance store like a database 
and Model class holds data in public properties. The data gathered from Postman JSON result which I can 
create properties for each of the data. 

OpenWeatherMapCallManager.cs - using RestSharp NuGet package to call the command IRestClient interface, 
public method to call the command RestClient (sets the BaseUrl property for requests made by the IResetCLient interface),
public method to call the command RestRequest to creates a new request to a Api_city and Api_key and To execute the request, the command
client.Execute(request with HTTP method (GET)) is used. the command response.Content for raw content to string. 
```


## Built With
```
Postman - Platform for API Developement to run the API
Gitbash - create, push, commit and pull Git Repository
Visual Studio - Create the project 
OpenWeather - API for testing
```




