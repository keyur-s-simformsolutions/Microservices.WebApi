using Microsoft.EntityFrameworkCore;
using Customer.Microservice.Modal;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Customer.Microservice.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Modal.Customer> Customers { get; set; }

    }
}
