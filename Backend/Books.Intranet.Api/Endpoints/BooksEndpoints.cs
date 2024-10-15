using Books.Intranet.Api.Dtos;

namespace Books.Intranet.Api.Endpoints
{
    public static class BooksEndpoints
    {

        public static void GetBooks(this WebApplication app)
        {
            app.MapGet("/books-bis", () =>
            {
                app.Logger.LogInformation("I'm getting books");
                app.Logger.LogDebug("I'm debugging GetBooks");
                app.Logger.LogError("I Get Error GetBooks");
                app.Logger.LogWarning("I GetBooks with warning");
                app.Logger.LogCritical("I'm GetBooks with critical log");


                var employees = Enumerable.Range(1, 2).Select(index =>

                        new Book(
                            index == 1 ? "C# developpement" : "Improve your communication skills",
                            DateOnly.FromDateTime(DateTime.Now).AddDays(index)
                        ))
                    .ToArray();

                return employees;
            }).WithName("List of books").WithOpenApi();
        }

        public static void GetRoot(this WebApplication app)
        {
            app.MapGet("/books", () =>
            {

                var message = "I love u soo much my pretty girl Titima <3";


                return message;
            }).WithName("Message").WithOpenApi();
        }

    }
}
