using ConsoleAppRefit.Services;
using Refit;
using System;

namespace ConsoleAppRefit
{
    class Program
    {
        static void Main(string[] args)
        {
            var refitService = RestService.For<IWeatherForecastRefit>("https://localhost:44345/");
            var response = refitService.GetFromHeader(1).Result;
            Console.WriteLine("Hello World!");
        }
    }
}
