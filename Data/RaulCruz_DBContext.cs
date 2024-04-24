using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RaulCruz_PruebaProgreso1.Models;

    public class RaulCruz_DBContext : DbContext
    {
        public RaulCruz_DBContext (DbContextOptions<RaulCruz_DBContext> options)
            : base(options)
        {
        }

        public DbSet<RaulCruz_PruebaProgreso1.Models.RC_Tabla1> RC_Tabla1 { get; set; } = default!;
    }
