namespace BaseData.Entities
{
    public class MonitoringType : EntityBase
    {
        public string Type { get; set; } = null!;
        public override string ToString() => Type;
       
       
    }
}
