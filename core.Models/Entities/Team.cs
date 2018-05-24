using core.Models.Entities;

using System.Collections.Generic;


namespace Core.Models.Entities
{
    public class Team
    {

        #region propierities
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region navegations

        //public ICollection<Person> Members { get; set; }
        
        #endregion
    }
}
