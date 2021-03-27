using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RealEstateProject.Authorization.Roles;
using RealEstateProject.Authorization.Users;
using RealEstateProject.MultiTenancy;
using RealEstateProject.Models.Entities;

namespace RealEstateProject.EntityFrameworkCore
{
    public class RealEstateProjectDbContext : AbpZeroDbContext<Tenant, Role, User, RealEstateProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<HeatingType> HeatingTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<EstateType> EstateTypes { get; set; }
        public RealEstateProjectDbContext(DbContextOptions<RealEstateProjectDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>(e =>
            {
                e.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(300);
                e.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(50);
                e.Property(c => c.PhoneNumber)
                .IsRequired()
                .HasMaxLength(15);
            });
            
            modelBuilder.Entity<CustomerType>(e =>
            {
                e.Property(ct => ct.Type)
                
                .IsRequired()
                .HasMaxLength(10);
            });
            modelBuilder.Entity<CustomerTypeCustomer>(e =>
            {
                e.HasKey(ctc => new { ctc.CustomerId, ctc.CustomerTypeId });
            });
        }

    }
}
