﻿using System;
using System.Collections.Generic;
using System.Text;

namespace core.Models.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                if (Birthday != null)
                {
                    DateTime now = DateTime.Today;
                    int age = now.Year - Birthday.Year;
                    if (now < Birthday.AddYears(age)) age--;

                    return age;
                }
                else {
                    return 0;
                }
            }
        }
        public string FullName
        {
            get
            {
                return Name + " " + MiddleName + " " + LastName;
            }
        }

    }
}