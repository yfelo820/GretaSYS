using System.ComponentModel.DataAnnotations.Schema;

namespace Greta.BO.Api.Entities
{
    public class Employee : BaseEntityLong
    {

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"${FirstName} ${LastName}";
            }
        }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public long CityId { get; set; }
        public long ProvinceId { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public City City { get; set; }
        public Province Province { get; set; }
    }
}
