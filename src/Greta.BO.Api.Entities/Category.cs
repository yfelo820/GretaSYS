using System.Collections.Generic;

namespace Greta.BO.Api.Entities
{
    public class Category : BaseEntityLong
    {

        public string Name { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
