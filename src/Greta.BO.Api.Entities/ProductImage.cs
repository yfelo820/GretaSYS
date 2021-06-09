namespace Greta.BO.Api.Entities
{
    public class ProductImage : BaseEntityLong
    {
        public string Path { get; set; }
        public bool IsPrimary { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
