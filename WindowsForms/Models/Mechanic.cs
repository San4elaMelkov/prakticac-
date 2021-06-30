using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Models
{
    class Mechanic : Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pay { get; set; }
        public int Experience { get; set; }
    }
}
