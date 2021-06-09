using Greta.BO.Api.Entities.Enum;
using System.Collections.Generic;

namespace Greta.BO.Api.Entities
{
    //[Table("Product")]
    public class Product : BaseEntityLong
    {
        /// <summary>
        /// UPC for a Scale Label product. 
        /// If the user is adding the UPC length of the UPC is 5 digits so we need to check Length on UPC entry on this type of product. The length is a 5 digits number only 0-9.
        /// </summary>
        public string UPC { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public long StoreProductId { get; set; }

        public long CategoryId { get; set; }

        public long FamilyId { get; set; }

        public ProductType ProductType { get; set; }

        public int MinimumAge { get; set; }

        public bool PosVisible { get; set; }

        public bool ScaleVisible { get; set; }

        public bool AllowZeroStock { get; set; }

        #region Inventory
        /// <summary>
        /// Qty on Hand
        /// </summary>
        public int QtyHand { get; set; }
        /// <summary>
        /// Not defined yet
        /// </summary>
        public int OrderTrigger { get; set; }
        /// <summary>
        /// Not defined yet
        /// </summary>
        public int OrderAmount { get; set; }
        #endregion Inventory

        public List<StoreProduct> StoreProducts { get; set; }
        public Category Category { get; set; }

        public Family Family { get; set; }

        public List<VendorProduct> VendorProducts { get; set; }

        public List<ProductImage> ProductImages { get; set; }

        public List<KitProduct> KitProducts { get; set; }
    }
}
