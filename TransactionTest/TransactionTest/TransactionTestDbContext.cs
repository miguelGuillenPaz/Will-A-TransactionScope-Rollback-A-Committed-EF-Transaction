﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionTest
{
    class TransactionTestDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
