﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication10.Models;

namespace WebApplication10.Data
{
    public class WebApplication10Context : DbContext
    {
        public WebApplication10Context (DbContextOptions<WebApplication10Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication10.Models.Product> Product { get; set; } = default!;
        public DbSet<WebApplication10.Models.AboutUs> AboutUs { get; set; } = default!;
    }
}
