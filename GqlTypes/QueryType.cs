
namespace GqlTypes;
public class Book {
    public int Id { get; set; }
    public string Name { get; set; }
    public int AuthorId { get; set; }

}
public class Author {
    public int Id { get; set; }
    public string Name { get; set; }
}
public class QueryType
{
    public Book GetBookById(int id)
    {
        return new Book()
        {
            Id = id,
            Name = "Book " + id,
            AuthorId = 1
        };
    }
    public Author GetAuthorById(int id)
    {
        return new Author()
        {
            Id = id,
            Name = "Author " + id
        };
    }
}