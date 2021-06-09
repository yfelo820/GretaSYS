using System.Collections.Generic;

namespace Greta.BO.Api.Entities
{
    public class Vendor : BaseLocationEntityLong
    {
        public string Name { get; set; }

        public string Contact { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        public string Note { get; set; }

        public double MinimalOrder { get; set; }

        public List<VendorProduct> VendorProducts { get; set; }

    }
}
