using System;
using System.Data.Linq.Mapping;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Models
{
    [Table(Name = "Konf")]
    class Konf
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public int UserId { get; set; }
        [Column]
        public string Tema { get; set; }
        [Column]
        public DateTime Data1 { get; set; }
        [Column]
        public int Otmetka { get; set; }
        [Column]
        public int Vznos { get; set; }
        [Column]
        public int isGost { get; set; }
    }
}
