using Greta.BO.Api.Entities.Enum;
using System.Collections.Generic;

namespace Greta.BO.Api.Entities
{
    public class Discount : BaseEntityLong
    {
        public string Name { get; set; }
        public DiscountType Type { get; set; }

        public double Value { get; set; }

        public List<StoreProduct> StoreProducts { get; set; }
        public List<Family> Families { get; set; }
    }
}
