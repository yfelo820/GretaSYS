using System.Collections.Generic;

namespace Greta.BO.Api.Entities
{
    public class ScaleCategory : BaseEntityLong
    {
        public string Name { get; set; }

        public List<ScaleProduct> ScaleProducts { get; set; }
    }
}
