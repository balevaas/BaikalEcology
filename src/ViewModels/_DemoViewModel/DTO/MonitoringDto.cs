using System;

namespace _DemoViewModel.DTO;

public class MonitoringDto
{
    public int Id { get; set; }
    public string MonitoringType { get; set; }
    public DateTime Date { get; set; }
    public string PointName { get; set; }
    public string PostName { get; set; }
    public string HarmName { get; set; }
    public double Quantity { get; set; }
}