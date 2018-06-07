using System.Collections.Generic;

namespace Core.Models.Entities
{
    public class Machine
    {
        public int Id { get; set; }

        public ICollection<Mecanico> Mecanicos { get; set; }
    }
}