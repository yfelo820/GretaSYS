using Greta.Sdk.Core.Abstractions;
using System;

namespace Greta.BO.Api.Entities
{
    public class BaseLocationEntityLong : IEntityLocationBase<long, string>
    {
        #region Base
        public long Id { get; set; }
        public bool State { get; set; }
        public string UserCreatorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        #endregion Base
    }
}
