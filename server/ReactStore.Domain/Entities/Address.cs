using System.ComponentModel.DataAnnotations;

namespace ReactStore.Domain.Entities
{
    public class Address
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address1 { get; set; }
        [Required]
        public string Address2 { get; set; }
        [Required]
        public string TownCity { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Postcode { get; set; }
    }
}