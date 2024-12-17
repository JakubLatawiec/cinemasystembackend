using Application.Interfaces;
using Application.Mappings;
using Application.Services;
using Domain.Interfaces;
using Domain.Repositories;
using DotNetEnv;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Text.Json.Serialization;
using WebAPI.Installers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IBuilder servicesBuilder = new ServicesBuilder();
servicesBuilder.Build(builder.Services);


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddAuthorization();

Env.Load();
var connectionString =
    $"Server={Environment.GetEnvironmentVariable("DB_SERVER")};" +
    $"Database={Environment.GetEnvironmentVariable("DB_NAME")};" +
    $"User Id={Environment.GetEnvironmentVariable("DB_USER")};" +
    $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")};" +
    $"Encrypt={Environment.GetEnvironmentVariable("DB_ENCRYPT")};" +
    $"TrustServerCertificate={Environment.GetEnvironmentVariable("DB_TRUST_SERVER_CERTIFICATE")};";

builder.Services.AddDbContext<CinemaDBContext>(options =>
{
    options.UseSqlServer(connectionString);
});

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("*");
                          policy.AllowAnyMethod();
                          policy.AllowAnyHeader();
                      });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Build app
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }