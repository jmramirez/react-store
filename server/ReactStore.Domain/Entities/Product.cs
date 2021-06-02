using System;
using System.Collections.Generic;

namespace ReactStore.Domain.Entities
{
    public class Product
    {       
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Thumbnail { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal ScreenSize { get; set; }
        public  decimal TalkTime { get; set; }
        public decimal StandByTime { get; set; }
        public Guid BrandId { get; set; }
        public Guid OSId { get; set; }
        
        public IEnumerable<Image> Images { get; set; }
        public Brand Brand { get; set; }
        public OS OS { get; set; }
        public IEnumerable<ProductFeature> ProductFeatures { get; set; }
        public IEnumerable<ProductVariant> ProductVariants { get; set; }
    }
}