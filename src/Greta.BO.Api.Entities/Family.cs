using System.Collections.Generic;

namespace Greta.BO.Api.Entities
{
    public class Family : BaseEntityLong
    {
        public string Name { get; set; }


        public List<Product> Products { get; set; }

        public List<Discount> Discounts { get; set; }
    }
}
