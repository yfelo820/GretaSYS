namespace Greta.BO.Api.Entities
{
    public class TenderType : BaseEntityLong
    {
        public string Name { get; set; }

        /// <summary>
        /// Determine if open drawer is needed
        /// </summary>
        public bool OpenDrawer { get; set; }

        public string DisplayAs { get; set; }

    }
}
