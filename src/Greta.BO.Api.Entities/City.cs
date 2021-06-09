using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Greta.BO.Api.Entities
{
    public class City : BaseEntityLong
    {
        public string Name { get; set; } 
        
        public long ProvinceId { get; set; }

    }
}
