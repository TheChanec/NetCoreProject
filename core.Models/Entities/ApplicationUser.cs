using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using core.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace Core.Models.Entities
{
    /// <summary>
    /// Add profile data for application users by adding properties to the ApplicationUser class
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        private string _name;
        private string _middleName;
        private string _lastName;
        private DateTime _birthday;

        #region Propierities

        /// <summary>
        /// Propierity only read for calculete Age of the date birthday
        /// </summary>
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

        /// <summary>
        /// Propierity only read for get the Full Name abouth the user
        /// </summary>
        public string FullName
        {
            get
            {
                return Name + " " + MiddleName + " " + LastName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Birthday { get => _birthday; set => _birthday = value; }

        /// <summary>
        /// 
        /// </summary>
        public string LastName { get => _lastName; set => _lastName = value; }

        /// <summary>
        /// 
        /// </summary>
        public string MiddleName { get => _middleName; set=> _middleName= value; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        #endregion

        #region Navigation
        //public Address Address { get; set; }
        public virtual ICollection<ApplicationUser> Friends { get; set; }


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
