using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroszimuláció.Entities
{
    public class DeathProbability
    {
        public int Age { get; set; }
        public int NbrOfChildren { get; set; }
        public Gender Gender { get; set; }
    }
}
