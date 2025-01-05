using Microsoft.EntityFrameworkCore;
using StripsDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL
{
    public class StripContext : DbContext
    {
        public DbSet<AuteurEF> Auteurs { get; set; }
        public DbSet<ReeksEF> Reeksen { get; set; }
        public DbSet<StripEF> Strips { get; set; }
        public DbSet<UitgeverijEF> Uitgeverijen { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-8PQJLNFG\SQLEXPRESS;Initial Catalog=Strips;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

    }
}
