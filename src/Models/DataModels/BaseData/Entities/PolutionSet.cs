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
        public DateTime? Date { get; set; }
        public double Quantity { get; set; }
        public Guid PointId { get; set; }
        public Point Point { get; set; } = null!;
        public Guid? WindRoseId { get; set; }
        public WindRoseHandler? WindRose { get; set; }
    }
}
