using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.Entities
{
    public class PolutionSet: EntityBase
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? PolutionId { get; set; }
        public Polution? Polution { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime? Date { get; set; }
        public double Quantity { get; set; }

    }
}
