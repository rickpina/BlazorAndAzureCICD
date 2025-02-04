using BlazorAndAzureCICD.Models;
using Microsoft.EntityFrameworkCore;


namespace BlazorAndAzureCICD
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }

}
