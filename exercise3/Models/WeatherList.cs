using System.Collections.Generic;

namespace exercise3.Models
{
    public class WeatherList
    {
        public int Dt { get; set; }
        public MainInfo MainInfo { get; set; }
        public List<Weather> Weather { get; set; }
        public Clouds Clouds { get; set; }
        public Wind Wind { get; set; }
        public Sys Sys { get; set; }
        public string DtTxt { get; set; }
        public Rain Rain { get; set; }
        public Snow Snow { get; set; }
    }
}