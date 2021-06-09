namespace Greta.BO.Api.Entities
{
    public class StoreConfiguration : BaseEntityLong
    {
        public string Language { get; set; }
        public string Currency { get; set; }

        public long StoreId { get; set; }
        public Store Store { get; set; }
    }
}
