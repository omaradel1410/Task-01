using ConsoleApp1.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Database
{
    public class DbContainer : DbContext
    {


        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Subjects> Subjects { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;database=Education;Trusted_Connection=True;Encrypt=False");
        }


 


    }
}
