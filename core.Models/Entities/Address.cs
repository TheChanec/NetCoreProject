using core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.Entities
{
    public class Address
    {



        public int Id { get; set; }
        
        public Person PersonInThisAddress { get; set; }
        
    }
}
