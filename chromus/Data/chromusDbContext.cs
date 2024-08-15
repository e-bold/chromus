using System;
using Microsoft.EntityFrameworkCore;

namespace chromus.Data;

public class chromustDbContext : DbContext
{
    public chromustDbContext(DbContextOptions<chromustDbContext> options) : base(options)
    {

    }

}
