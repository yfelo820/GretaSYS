namespace Greta.BO.Api.Entities
{
    public class VendorProduct : BaseEntityLong
    {
        public long ProductId { get; set; }

        public long VendorId { get; set; }

        public string ProductCode { get; set; }

        public bool IsPrimary { get; set; }

        public int PackQty { get; set; }

        public double Price { get; set; }


        public Product Product { get; set; }

        public Vendor Vendor { get; set; }
    }
}
