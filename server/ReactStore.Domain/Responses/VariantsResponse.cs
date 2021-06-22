using System;

namespace ReactStore.Domain.Responses
{
    public class VariantsResponse
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public Guid ColorId { get; set; }
        public string Color { get; set; }
        public Guid StorageId { get; set; }
        public string Capacity { get; set; }
        public decimal Price { get; set; }
    }
}