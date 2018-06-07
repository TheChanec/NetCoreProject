using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.Entities
{
    public class Mecanico : Person
    {
        public ICollection<Machine> Machines { get; set; }
    }
}
