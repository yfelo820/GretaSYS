namespace Greta.BO.Api.Entities
{
    public class KitProductProduct
    {
        public long KitProductId { get; set; }
        public long ProductId { get; set; }

        public KitProduct KitProduct { get; set; }
        public Product Product { get; set; }
    }
}
