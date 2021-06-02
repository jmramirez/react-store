﻿using System;

namespace ReactStore.Domain.Entities
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public Guid ProductId { get; set; }
        
        public Product Product { get; set; }
    }
}