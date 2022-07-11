using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CodeBasedEvaluation_06.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CodeBasedEvaluation_06Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CodeBasedEvaluation_06Context") ?? throw new InvalidOperationException("Connection string 'CodeBasedEvaluation_06Context' not found.")));

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
