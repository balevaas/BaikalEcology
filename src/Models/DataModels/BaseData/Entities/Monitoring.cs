using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.Entities
{
    public class Monitoring : EntityBase
    {
        public MonitoringType MonitoringType { get; set; } = null!;
        public DateTime Date { get; set; }
        public Point Point { get; set; } = null!;
        public Post Post { get; set; } = null!;
        public HarmSubstance Substance { get; set; } = null!;
        public double Quantity { get; set; }
    }
}
