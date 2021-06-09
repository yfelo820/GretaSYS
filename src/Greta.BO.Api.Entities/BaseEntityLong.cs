using Greta.Sdk.Core.Abstractions;
using System;

namespace Greta.BO.Api.Entities
{
    public class BaseEntityLong : IEntityLong<string>
    {
        #region Base
        public long Id { get; set; }
        public bool State { get; set; }
        public string UserCreatorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion Base
    }
}
