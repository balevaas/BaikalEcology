using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.Entities
{
    public class PollutionField : EntityBase
    {
        public DateTime Date { get; set; }
        public string Name { get; set; } = null!;
        public string LinkFile { get; set; } = null!;
        public string LinkImage { get; set; } = null!;
        public SoftModule SoftModule { get; set; } = null!;
    }
}
