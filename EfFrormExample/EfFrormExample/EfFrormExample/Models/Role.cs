using EfFrormExample.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFrormExample.Models
{
    public class Role:CommonProperty
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
