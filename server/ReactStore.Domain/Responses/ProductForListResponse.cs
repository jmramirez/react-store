using System;

namespace ReactStore.Domain.Responses
{
    public class ProductForListResponse
    {
        public Guid Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public string Thumbnail { get; set; }
    }
}