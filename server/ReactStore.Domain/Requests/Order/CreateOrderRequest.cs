using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReactStore.Domain.Requests.Order
{
    public class CreateOrderRequest
    {
        [Required]
        public string StripeToken { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [Required]
        public string TownCity { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Postcode { get; set; }
        
        public List<OrderItemRequest> Items { get; set; }
    }
}