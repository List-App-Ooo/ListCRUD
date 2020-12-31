using Microsoft.EntityFrameworkCore;
using ListCRUD.Models;

namespace TodoCRUD.Data
{
    public class ListContext : DbContext
    {
        public ListContext(DbContextOptions<ListContext> options) : base(options) {}

        public DbSet<ListModel<ItemModel>> Lists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}