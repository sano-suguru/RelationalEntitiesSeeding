using Microsoft.EntityFrameworkCore;
using RelationalEntitiesSeeding.Entities;
using System;

namespace RelationalEntitiesSeeding.Data {
  public class MyDbContext : DbContext {
    public MyDbContext(DbContextOptions<MyDbContext> options)
      : base(options) { }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      modelBuilder.Entity<Author>(entity => {
        entity.Property(author => author.Name).IsRequired();
        entity.HasData(
          new Author { AuthorId = 1, Name = "フィリップ・K・ディック", Birthday = DateTime.Parse("1928/12/16") },
          new Author { AuthorId = 2, Name = "ジョージ・オーウェル", Birthday = DateTime.Parse("1903/06/25") }
        );
      });


      modelBuilder.Entity<Book>(entity => {
        entity.Property(book => book.Title).IsRequired();
        entity.HasOne(book => book.Author).WithMany(author => author.Books);
        entity.HasData(
          new Book { BookId = 1, Title = "アンドロイドは電気羊の夢を見るか?", PublushYear = 1969, AuthorId = 1 },
          new Book { BookId = 2, Title = "高い城の男", PublushYear = 1962, AuthorId = 1 },
          new Book { BookId = 3, Title = "1984年", PublushYear = 1949, AuthorId = 2 }
        );
      });
    }
  }
}
