using Library_manangement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_manangement.Data
{
    public class LibraryDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Issue> Issues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=;database=library_management";
            var serverVersion = new MySqlServerVersion(new Version(10, 4, 27));
            optionsBuilder.UseMySql(connectionString,serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Books");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.ID).HasColumnName("ID");
                entity.Property(e => e.BookTitle).HasColumnName("BookTitle"); // Adjust if needed
                entity.Property(e => e.Author).HasColumnName("Author");
                entity.Property(e => e.Published).HasColumnName("Published");
                entity.Property(e => e.Status).HasColumnName("Status");
                entity.Property(e => e.DataInsert).HasColumnName("DataInsert");
                entity.Property(e => e.DateDelete).HasColumnName("DateDelete");  // Nullable field
                entity.Property(e => e.DateUpdate).HasColumnName("DateUpdate");  // Nullable field
            });
        }
    }
}
