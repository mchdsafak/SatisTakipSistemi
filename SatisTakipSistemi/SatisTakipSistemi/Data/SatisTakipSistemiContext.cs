using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SatisTakipSistemi.Models;

namespace SatisTakipSistemi.Data
{
    public class SatisTakipSistemiContext : DbContext
    {
        public SatisTakipSistemiContext (DbContextOptions<SatisTakipSistemiContext> options)
            : base(options)
        {
        }

        public DbSet<SatisTakipSistemi.Models.SatisKaydi> SatisKaydi { get; set; } = default!;
    }
}
