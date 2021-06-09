namespace Greta.BO.Api.Entities
{
    public class Department : BaseEntityLong
    {
        public string Name { get; set; }

        #region Store
        public long StoreId { get; set; }
        public Store Store { get; set; }
        #endregion Store



    }
}
