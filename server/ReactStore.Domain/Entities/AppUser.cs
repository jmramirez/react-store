﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ReactStore.Domain.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RefreshToken { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}