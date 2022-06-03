using Microsoft.EntityFrameworkCore;
using TesteEngegraph.Models;

namespace TesteEngegraph.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<ContactModel> Contatos { get; set; }

        public DbSet<TypeModel> Tipos { get; set; }
    }
}
