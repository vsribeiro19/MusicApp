using Microsoft.EntityFrameworkCore;
using MusicApp.Api.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DatabaseContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("MusicApp")));
var app = builder.Build();

builder.Services.AddCors(option => option.AddDefaultPolicy(policy =>
{
    policy.AllowAnyOrigin();
    policy.AllowAnyMethod();
    policy.AllowAnyHeader();
}));




app.UseCors();
app.MapGet("/", () => "Hello World!"); 

app.Run();
