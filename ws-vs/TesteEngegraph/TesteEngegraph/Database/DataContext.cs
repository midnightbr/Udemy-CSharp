using Microsoft.EntityFrameworkCore;
using TesteEngegraph.Models;

namespace TesteEngegraph.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Types>()
        //        .HasOne(types => types.Contact)
        //        .WithOne(contact => contact.Types)
        //        .HasForeignKey<Contact>(contact => contact.TypesId);
        //}

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Types> Types { get; set; }
    }
}
