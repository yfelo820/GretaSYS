using Greta.BO.Api.Entities.Enum;
using System.Collections.Generic;

namespace Greta.BO.Api.Entities
{
    public class Tax : BaseEntityLong
    {
        public string Name { get; set; }
        public TaxType Type { get; set; }
        public double Value { get; set; }

        public List<StoreProduct> StoreProducts { get; set; }

    }
}
