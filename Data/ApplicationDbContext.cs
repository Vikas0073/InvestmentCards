using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using nextinvesting.Models;

namespace nextinvesting.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<nextinvesting.Models.Investment> Investment { get; set; }
        public DbSet<nextinvesting.Models.InvestmentOpportunities> InvestmentOpportunities { get; set; }
        public DbSet<nextinvesting.Models.AboutUs> AboutUs { get; set; }
    }
}
