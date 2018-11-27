namespace RelationalEntitiesSeeding.Entities {
  public class Book {
    public int BookId { get; set; }
    public string Title { get; set; }
    public int PublushYear { get; set; }

    public int AuthorId { get; set; }
    public Author Author { get; set; }
  }
}
