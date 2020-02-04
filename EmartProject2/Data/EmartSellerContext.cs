using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmartProject2.Models;

    public class EmartSellerContext : DbContext
    {
        public EmartSellerContext (DbContextOptions<EmartSellerContext> options)
            : base(options)
        {
        }

        public DbSet<EmartProject2.Models.Seller> Seller { get; set; }
    }
