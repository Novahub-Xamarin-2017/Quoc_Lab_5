using System;
using exercise3.Models;
using RestSharp;
using Retrofit.Net;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://api.openweathermap.org/data/2.5";
            var adapter = new RestAdapter(url);
            var service = adapter.Create<IWeatherService>();
            // get weather's info of London
            var cityName = "London";
            Console.WriteLine(service.GetWeatherInfoByCityName(cityName).Content);
            // get weather's info of the city has id = 2172797
            var cityId = "2172797";
            Console.WriteLine(service.GetWeatherInfoByCityId(cityId).Content);
            // get weather's info of the city has Geographic Coordinates lat = 35, lon = 139
            var lat = 35;
            var lon = 139;
            Console.WriteLine(service.GetWeatherInfoByGeographicCoordinates(lat,lon).Content);
            // get weather's info of the city has zipcode = 94040 and countryCode = us
            var zipCode = 94040;
            var countryCode = "us";
            Console.WriteLine(service.GetWeatherInfoByZipCode(zipCode,countryCode).Content);
            Console.ReadKey();
        }
    }
}
