using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using BibliotecaApp.Data;
using BibliotecaApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<BibliotecaContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")!));

builder.Services.AddCors();
builder.Services.AddScoped<AuthService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors(policy => policy
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.MapScalarApiReference();

app.Run();
