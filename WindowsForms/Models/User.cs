using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Models
{
    [Table(Name = "Users")]
    class User : Model
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public string Email { get; set; }
        [Column]
        public string Stupen { get; set; }
        [Column]
        public string Zvanie { get; set; }
        [Column]
        public string Rabota { get; set; }
    }
}
