using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=CVProje;integrated security=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Deneyim> Deneyims { get; set; }
        public DbSet<Egitim> Egitims { get; set; }
        public DbSet<IlgiAlanlari> ılgiAlanlaris { get; set; }
        public DbSet<Yetenekler> yeteneklers { get; set; }




    }
}
