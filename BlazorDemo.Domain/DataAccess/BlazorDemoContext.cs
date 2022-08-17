using BlazorDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.Domain.DataAccess
{
    public class BlazorDemoContext : DbContext
    {
        public BlazorDemoContext (DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Phone> Phone { get; set; }

    }
}
