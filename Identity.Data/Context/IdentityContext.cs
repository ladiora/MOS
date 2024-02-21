
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.Data.Context
{
    public class IdentityContext : IdentityDbContext
    {
        public IdentityContext()
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }



    }
}