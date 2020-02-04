using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmartProject2.Models;

public class EmartItemContext : DbContext
{
    public EmartItemContext(DbContextOptions<EmartItemContext> options)
        : base(options)
    {
    }

    public DbSet<EmartProject2.Models.Item> Item { get; set; }
    public DbSet<EmartProject2.Models.SubCategory> SubCategory { get; set; }
}
