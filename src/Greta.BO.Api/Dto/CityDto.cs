﻿using Greta.Sdk.Core.Abstractions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Greta.BO.Api.Dto
{
    public class CityDto : IDtoLong<string>
    {
        public long Id { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "The {0} field not is valid")]
        public string Name { get; set; }

        public bool State { get; set; }
        public string UserCreatorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
