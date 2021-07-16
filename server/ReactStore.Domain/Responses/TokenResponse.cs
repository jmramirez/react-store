using System.Collections.Generic;

namespace ReactStore.Domain.Responses
{
    public class TokenResponse
    {
        public string Token { get; set; }
        public string FullName { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}