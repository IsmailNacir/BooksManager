using Books.Intranet.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapGet("/books", () =>
{
    var employees = Enumerable.Range(1, 2).Select(index =>

    new Book(
        index == 1 ? "C# developpement" : "Improve your communication skills",
        DateOnly.FromDateTime(DateTime.Now).AddDays(index)
    ))
        .ToArray();

    return employees;
}).WithName("List of books").WithOpenApi();

app.Run();