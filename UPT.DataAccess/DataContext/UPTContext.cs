using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UPT.DataAccess.DbModels;

namespace UPT.DataAccess.DataContext
{
    public class UPTContext: IdentityDbContext
    {
        public UPTContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Subscriptions> Subscriptions { get; set; }
        public DbSet<Debts> Debts { get; set; }
        public DbSet<Deposits> Deposits { get; set; }
        public DbSet<Payments> Payments { get; set; }
    }
}
