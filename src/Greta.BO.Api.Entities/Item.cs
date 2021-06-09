using Greta.BO.Api.Entities.Enum;

namespace Greta.BO.Api.Entities
{
    class Item : BaseEntityLong
    {
        public long DeviceId { get; set; }

        #region Tax
        public long TaxId { get; set; }
        public decimal Tax { get; set; }
        #endregion Tax

        #region Discount
        public long DiscountId { get; set; }
        public decimal Discount { get; set; }
        public string DiscountName { get; set; }
        #endregion Discount


        public long IdInvoice { get; set; }
        public Invoice Invoice { get; set; }

        public double Qty { get; set; }

        public decimal Rate { get; set; }
        public decimal Price { get; set; }

        public long IdCategory { get; set; }
        public string CategoryName { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
