﻿using Microsoft.EntityFrameworkCore;
using Retail.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Repository
{
    public class RetailDbContext : DbContext
    {
        public RetailDbContext(DbContextOptions<RetailDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}