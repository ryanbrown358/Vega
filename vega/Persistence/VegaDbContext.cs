﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vega.Models;

namespace vega.Persistence
{
    public class VegaDbContext : DbContext

    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        {
            // System.ConfigurationManager 
        }

        public DbSet<Make> Makes { get; set; }
    }
}
