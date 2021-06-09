using System.Collections.Generic;

namespace Greta.BO.Api.Entities
{
    public class Store : BaseEntityLong
    {
        public string Name { get; set; }


        public List<StoreProduct> StoreProducts { get; set; }

        public List<ExternalScale> ExternalScales { get; set; }
    }
}
