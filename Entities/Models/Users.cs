using Microsoft.AspNet.Identity.EntityFramework;

namespace Entities.Models
{
    public class Users : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}