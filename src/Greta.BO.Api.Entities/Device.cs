namespace Greta.BO.Api.Entities
{
    public class Device : BaseEntityLong
    {
        public int SyncroVersion { get; set; }

        public long StoreId { get; set; }

        public Store Store { get; set; }
    }
}
