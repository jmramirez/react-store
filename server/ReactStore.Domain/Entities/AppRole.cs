using Microsoft.AspNetCore.Identity;

namespace ReactStore.Domain.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public AppRole(){ }

        public AppRole(string name)
        {
            Name = name;
        }
    }
}