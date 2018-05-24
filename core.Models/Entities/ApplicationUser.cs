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
        
        /// <summary>
        /// The propierities about this objets
        /// </summary>
        #region Propierities

        [Key]
        public int UserId { get; set; }
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
        public DateTime Birthday { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Name { get; set; }
        public string IdApplicationUser { get; set; }

        #endregion



        /// <summary>
        /// All the navigation propierities
        /// </summary>
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
