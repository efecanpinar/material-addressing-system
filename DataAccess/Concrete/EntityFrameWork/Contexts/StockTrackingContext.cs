using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace DataAccess.Concrete.EntityFrameWork.Contexts
{
    public class StockTrackingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=DESKTOP-N4NOG7S\EFECANPINAR;Initial Catalog=Mustafa;Integrated Security=True");
        }

        public DbSet<Hall> Halls { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Shelf> Shelfs { get; set; }
        public DbSet<Part> Parts { get; set; }

    }
}
