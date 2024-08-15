using System;
using chromus.Models;
using Microsoft.EntityFrameworkCore;

namespace chromus.Data;

public class chromusDbContext : DbContext
{
    public chromusDbContext(DbContextOptions<chromusDbContext> options) : base(options)
    {

    }

    public DbSet<UserAccount> UserAccounts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}
