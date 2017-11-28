using System.Collections.Generic;

namespace exercise3.Models
{
    public class WeatherObject
    {
        public string Cod { get; set; }
        public double Message { get; set; }
        public int Cnt { get; set; }
        public List<WeatherList> List { get; set; }
        public City City { get; set; }
    }
}