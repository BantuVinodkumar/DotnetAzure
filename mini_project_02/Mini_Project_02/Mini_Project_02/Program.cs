using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mini_Project_02.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Mini_Project_02Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Mini_Project_02Context") ?? throw new InvalidOperationException("Connection string 'Mini_Project_02Context' not found.")));

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();
app.UseCors(builder => builder
.AllowAnyHeader()
.AllowAnyOrigin()
.AllowAnyMethod());

app.MapControllers();

app.Run();
