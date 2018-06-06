using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.Entities
{
    public class School
    {
        private string _name;
        private string _slogan;
        private DateTime _beging;

        //private Address _adress;


        //private ICollection<ApplicationUser> _students;
        //private ICollection<ApplicationUser> _workers;
        




        public School()
        {


        }

        public School(string name, string slogan, DateTime beging)
        {
            _name = name;
            _slogan = slogan;
            _beging = beging;
        }
    }
}
