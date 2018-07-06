using System.Collections.Generic;
using Core.Models.Entities;

namespace Core.Models
{
    public class Machine
    {
        public Machine(int id, ICollection<Mecanico> mecanicos)
        {
            Id = id;
            Mecanicos = mecanicos;
        }


        public int Id { get; set; }

        public ICollection<Mecanico> Mecanicos { get; set; }
    }
}