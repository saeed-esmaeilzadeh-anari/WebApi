using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddDbContext<RecipeContext>(options => options.UseNpgsql(
//  builder.Configuration.GetConnectionString("defaultConnection")
//  ));

builder.Services.AddDbContext<RecipeContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("defaultConnection")));

builder.Services.AddCors();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(options => options.WithOrigins("http://localhost:4300")
.AllowAnyMethod()
.AllowAnyHeader());
app.UseAuthorization();

app.MapControllers();

app.Run();
