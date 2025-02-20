using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportTime.DAL.Entities
{
   public class Admin
    {
        public long AdminId { get; set; }
        public string? Name { get; set; }
        public string? Number { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public Dictionary<double, double>? Location { get; set; }
    }
}
