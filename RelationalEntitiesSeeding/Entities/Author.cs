using System;
using System.Collections.Generic;

namespace RelationalEntitiesSeeding.Entities {
  public class Author {
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public IList<Book> Books { get; set; }
  }
}
