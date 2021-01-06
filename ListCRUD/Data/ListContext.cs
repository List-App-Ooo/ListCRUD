using Microsoft.EntityFrameworkCore;
using ListCRUD.Models;

namespace ListCRUD.Data
{
    public class ListContext : DbContext
    {
        public ListContext(DbContextOptions<ListContext> options) : base(options) {}

        public DbSet<ListModel<TypeModel>> Lists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}