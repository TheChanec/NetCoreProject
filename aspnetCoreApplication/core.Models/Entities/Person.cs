using System;
using System.Collections.Generic;
using System.Text;

namespace core.Models.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

    }
}
