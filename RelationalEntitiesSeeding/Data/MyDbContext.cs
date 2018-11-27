using Microsoft.EntityFrameworkCore;
using RelationalEntitiesSeeding.Entities;

namespace RelationalEntitiesSeeding.Data {
  public class MyDbContext : DbContext {
    public MyDbContext(DbContextOptions<MyDbContext> options)
      : base(options) { }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
  }
}
