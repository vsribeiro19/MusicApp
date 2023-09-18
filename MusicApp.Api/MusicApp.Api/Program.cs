using Microsoft.EntityFrameworkCore;
using MusicApp.Api.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DatabaseContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("MusicApp")));
var app = builder.Build();




app.MapGet("/", () => "Hello World!"); 

app.Run();
