using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace Core.Models.Entities
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public Person Owner { get; set; }
    }
}
