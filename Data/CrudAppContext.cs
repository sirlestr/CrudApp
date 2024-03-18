﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudApp.Models;

namespace CrudApp.Data
{
    public class CrudAppContext : DbContext
    {
        public CrudAppContext (DbContextOptions<CrudAppContext> options)
            : base(options)
        {
        }

        public DbSet<CrudApp.Models.People> People { get; set; } = default!;
    }
}
