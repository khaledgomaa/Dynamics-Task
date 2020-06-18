using Dynamics.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics.Repository
{
    public class DynamicsDbContext : DbContext
    {
        public DynamicsDbContext(DbContextOptions<DynamicsDbContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<InvoiceProducts> InvoiceProducts { get; set; }

        public DbSet<Store> Stores { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
