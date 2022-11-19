using DataGridView1.Property;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView1
{

    public class DataB : DbContext
    {
        public DbSet<Abiturient> AbiturientsDB { get; set; }

        public DataB(DbContextOptions<DataB> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abiturient>().HasKey(u => u.Id);
        }
    }
}
    
