using System.Collections.Generic;

namespace Greta.BO.Api.Entities
{
    public class StoreProduct : BaseEntityLong
    {
        public long ProductId { get; set; }

        public long StoreId { get; set; }

        #region Price
        public decimal Price { get; set; }

        public decimal Cost { get; set; }
        /// <summary>
        /// Percent 0.00   format  7.25%
        /// Gross Profit if Cost = 0.00 Then Gross Profit = 0.00 Else Gross Profit = Retail - Cost / Retail 
        /// “No negative number allowed in Retail or Cost”. Then mark the record as CHANGED
        /// </summary>
        public decimal GrossProfit { get; set; }

        #endregion Price


        public Product Product { get; set; }
        public Store Store { get; set; }

        public List<Tax> Taxs { get; set; }

        public List<Discount> Discounts { get; set; }

    }
}
