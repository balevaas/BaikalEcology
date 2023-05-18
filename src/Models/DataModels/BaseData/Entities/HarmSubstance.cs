using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.Entities
{
    public class HarmSubstance : EntityBase
    {
        public string Name { get; set; } = null!;
        public string Unit { get ; set; } = "мг/м3";
    }
}
