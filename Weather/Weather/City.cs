using System;
using System.Collections.Generic;
using System.Text;

namespace Weather
{
    public class City
    {
        public City(string name, CityType type, Dictionary<string, double> temperaturePerMonths)
        {
            Name = name;
            Type = type;
            TemperaturePerMonths = temperaturePerMonths;
        }

        public string Name { get; set; }
        public CityType Type { get; set; }
        public Dictionary<string, double> TemperaturePerMonths { get; set; } 
    }
}
