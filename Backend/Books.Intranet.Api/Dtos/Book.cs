namespace Books.Intranet.Api.Dtos;

public class Book
{
    public string Title { get; set; }
    public DateOnly PublicationDate { get; set; }

    public Book(string title, DateOnly publicationDate)
    {
        Title = title;
        PublicationDate = publicationDate;
    }
}