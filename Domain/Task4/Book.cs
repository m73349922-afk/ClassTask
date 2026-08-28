namespace Domain.Task4;

public class Book
{
    public string Title = "";
    public string Author = "";
    public int PublicationYear;
    public Book()
    {
    }
    public Book(string title, string author, int publication)
    {
        Title = title;
        Author = author;
        PublicationYear = publication;
    }
}
