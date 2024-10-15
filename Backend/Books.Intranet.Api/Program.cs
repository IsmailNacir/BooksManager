using Books.Intranet.Api.Dtos;
using Books.Intranet.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Loging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.GetBooks();
app.GetRoot();

app.Run();