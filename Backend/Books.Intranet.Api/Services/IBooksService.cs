using Books.Intranet.Api.Dtos;

namespace Books.Intranet.Api.Services;

public interface IBooksService
{
    List<Book> GetBooks();
}