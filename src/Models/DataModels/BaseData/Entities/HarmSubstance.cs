namespace BaseData.Entities
{
    public class HarmSubstance : EntityBase
    {
        public string Name { get; set; } = null!;
        public string Unit { get ; set; } = "мг/м3";
        public override string ToString() => $"{Name} ({Unit})";                     
    }
}
