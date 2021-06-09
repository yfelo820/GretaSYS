namespace Greta.BO.Api.Entities
{
    public class ExternalScale : BaseEntityLong
    {
        public string Ip { get; set; }

        public string Port { get; set; }

        public long ScaleBrandId { get; set; }

        public long StoreId { get; set; }

        public ScaleBrand ScaleBrand { get; set; }

        public Store Store { get; set; }
    }
}
