using System;
using System.Collections;
using System.Collections.Generic;

namespace ReactStore.Domain.Responses
{
    public class ProductItemResponse
    {
        public Guid Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Thumbnail { get; set; }
        public IEnumerable<ImageResponse> Images { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public IEnumerable<FeatureResponse> Features { get; set; }
        public IEnumerable<VariantsResponse> ProductVariants { get; set; }
    }
}