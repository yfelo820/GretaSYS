using System.Collections.Generic;

namespace Greta.BO.Api.Entities
{
    public class Province : BaseEntityLong
    {
        public string Name { get; set; }
        
        public long CountryID { get; set; }

        public List<City> Cities { get; set; }
    }
}
