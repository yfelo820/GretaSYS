using Greta.Sdk.Core.Abstractions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Greta.BO.Api.Dto
{
    public class VendorDto : IDtoLong<string>
    {
        public long Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} field not is valid")]
        public string Name { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "The {0} field not is valid")]
        public string Contact { get; set; }
        [Required]
        [Phone]
        [StringLength(12, ErrorMessage = "The {0} field not is valid")]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Note { get; set; }

        public double MinimalOrder { get; set; }



        public bool State { get; set; }
        public string UserCreatorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
