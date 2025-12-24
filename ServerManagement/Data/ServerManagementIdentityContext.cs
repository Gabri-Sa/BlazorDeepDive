using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ServerManagement.Data
{
    public class ServerManagementIdentityContext(DbContextOptions<ServerManagementIdentityContext> options) : IdentityDbContext<IdentityUser>(options)
    {
    }
}
