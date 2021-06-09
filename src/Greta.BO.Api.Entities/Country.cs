using System;
using System.Collections.Generic;
using System.Text;

namespace Greta.BO.Api.Entities
{
    public class Country : BaseEntityLong
    {

       public string Name { get; set; }          

       public List<Province> Provinces { get; set; }
      

    }
}
