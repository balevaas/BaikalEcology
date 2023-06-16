using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DemoViewModel.DTO
{
    public class WeatherDataDto
    {
        public int Station { get; set; }
        public DateTime Date { get; set; }
        public decimal Wind_Direction { get; set; }
        public int Wind_Speed { get; set; }
        public decimal Temperature { get; set; }
        public int Humidity { get; set; }
        public decimal Pressure { get; set; }
        public int Snow_Height { get; set; }
    }
}
