using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseData.Entities
{
    public class User : EntityBase
    {
        public string Surname { get; set; } = null!;

        public string Name { get; set; } = null!;      
    }
}
