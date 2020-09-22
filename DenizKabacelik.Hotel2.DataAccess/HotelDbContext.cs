using DenizKabacelik.Hotel2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKabacelik.Hotel2.DataAccess
{
   public  class HotelDbContext:DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-KDK0AO7;Database=HotelDb10;Integrated Security=true");
        }
        public DbSet<Hotel > Hotels { get; set; }
    }
}
