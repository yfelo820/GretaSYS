using System.Collections.Generic;

namespace Greta.BO.Api.Entities
{
    public class KitProduct : Product
    {
        public List<Product> Products { get; set; }
    }
}
