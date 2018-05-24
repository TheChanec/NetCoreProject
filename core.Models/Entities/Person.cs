using Core.Models;
using Core.Models.Entities;
using System;
using System.Collections.Generic;


namespace core.Models.Entities
{
    /// <summary>
    /// Entity Person whit the main propierities about the real person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// The propierities about this objets
        /// </summary>
        #region Propierities

        private int _id;
        private string _name;
        private string _middleName;
        private string _lastName;
        private DateTime _birthday;



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
                else
                {
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
        public DateTime Birthday { get => _birthday; set => _birthday = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string MiddleName { get => _middleName; set => _middleName = value; }
        public string Name { get => _name; set => _name = value; }

        #endregion



        /// <summary>
        /// All the navigation propierities
        /// </summary>
        #region Navigation

        //public ApplicationUser ApplicationUser { get; set; }
        public TeamSport FavoriteSportTeam { get; set; }
        public Address Address { get; set; }
        public virtual ICollection<Person> Friends { get; set; }


        #endregion


        //#region Singleton

        //private static readonly Person instance = new Person();

        //private Person() { }


        //public static Person Instance
        //{
        //    get
        //    {
        //        return instance;
        //    }
        //}
        //#endregion
    }
}
