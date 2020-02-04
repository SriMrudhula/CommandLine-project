using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmartProject2.Models;

    public class EmartBuyerContext : DbContext
    {
        public EmartBuyerContext (DbContextOptions<EmartBuyerContext> options)
            : base(options)
        {
        }

        public DbSet<EmartProject2.Models.Buyer> Buyer { get; set; }

    }
