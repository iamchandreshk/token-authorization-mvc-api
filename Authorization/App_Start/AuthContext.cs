using Microsoft.AspNet.Identity.EntityFramework;

namespace Authorization.App_Start
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext(): base("AuthContext")
        {

        }
    }
}