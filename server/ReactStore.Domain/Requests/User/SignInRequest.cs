﻿using System.Collections.Generic;

namespace ReactStore.Domain.Requests.User
{
    public class SignInRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}