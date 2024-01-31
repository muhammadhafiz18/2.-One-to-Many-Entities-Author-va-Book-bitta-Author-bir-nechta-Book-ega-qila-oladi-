using Microsoft.EntityFrameworkCore;
using OneToManyTask2.models;

namespace OneToManyTask2.context
{
    public class OneToManyDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=HAFIZ; database=OneToManyDB; Integrated Security=true; Encrypt=False") ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(a => a.books)
                .WithOne(b => b.Author)
                .HasForeignKey(o => o.AuthorID);
        }
    }
}
