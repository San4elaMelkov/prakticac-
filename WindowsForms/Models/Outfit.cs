using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Models
{
    class Outfit : Model
    {
        public int Id { get; set; }
        public int AutoId { get; set; }
        public int MechId { get; set; }
        public string Status { get; set; }
    }
}
