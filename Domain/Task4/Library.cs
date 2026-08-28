namespace Domain.Task4;

public class Library
{
    public string Name = "";
    List<Book> books = new List<Book>();
    public Library()
    {
    }
    public Library(string name)
    {
        Name = name;
    }
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }
    public void SearchBook(string title)
    {
        foreach (var item in books)
        {
            if (item.Title == title)
            {
                Console.WriteLine("Title: " + item);
            }
        }
    }
    public void GetResult(Book book)
    {
        Console.WriteLine($"Title: {book.Title}");
        System.Console.WriteLine($"Author: {book.Author}");
        System.Console.WriteLine($"Year: {book.PublicationYear}");
    }
}