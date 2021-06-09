using System.Collections.Generic;

namespace Greta.BO.Api.Entities
{
    public class ScaleBrand : BaseEntityLong
    {
        public string Name { get; set; }

        public List<ExternalScale> ExternalScales { get; set; }
    }
}
