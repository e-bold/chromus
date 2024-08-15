using System;
using Microsoft.EntityFrameworkCore;

namespace chromus.Data;

public class chromusDbContext : DbContext
{
    public chromusDbContext(DbContextOptions<chromusDbContext> options) : base(options)
    {

    }

}
