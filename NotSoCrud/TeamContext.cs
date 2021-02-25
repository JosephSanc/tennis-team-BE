using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NotSoCrud
{
    class TeamContext : DbContext
    {

        public DbSet<Player> Players { get; set; }
        public DbSet<Staff> Staff_Members { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-63G7O3I\SQLEXPRESS;Database=TeamDB;Trusted_Connection=True;");
        }

    }
}
