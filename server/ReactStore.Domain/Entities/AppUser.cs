using System.ComponentModel.DataAnnotations.Schema;

namespace ReactStore.Domain.Entities
{
    public class AppUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RefreshToken { get; set; }

        [NotMapped]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}