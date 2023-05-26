using System;

namespace BaseData.Entities
{
    public class Monitoring : EntityBase
    {
        public MonitoringType MonitoringType { get; set; } = null!;
        public DateTime Date { get; set; }
        public string PointName { get; set; } = null!;
        public string PostName { get; set; } = null!;
        public HarmSubstance Substance { get; set; } = null!;
        public double Quantity { get; set; }
    }
}
