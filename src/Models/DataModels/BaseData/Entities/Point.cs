using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.Entities
{
    public class Point : EntityBase
    {
        public string? Name { get; set; }
        public string? CityName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
