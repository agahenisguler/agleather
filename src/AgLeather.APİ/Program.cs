using AgLeather.APÝ.Filters;
using AgLeather.Shop.Application.Automap;
using AgLeather.Shop.Application.Services.Abstractions;
using AgLeather.Shop.Application.Services.Implementation;
using AgLeather.Shop.Application.Validators;
using AgLeather.Shop.Persistance.Context;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

//logging
var configuration = new ConfigurationBuilder()
       .SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json")
       .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", true)
       .Build();

Log.Logger = new LoggerConfiguration()
      .ReadFrom.Configuration(configuration)
      .CreateLogger();

Log.Logger.Information("PROGRAM STARTED...");
// Add services to the container.

builder.Services.AddControllers(opt =>
{
    opt.Filters.Add(new ExceptionHandlerFilter());
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AgLeatherContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("AgLeatherConnection"));
});

//Bussiness Service Registiration
builder.Services.AddScoped<ICategoryService, CategoryService>();

//Automapper
builder.Services.AddAutoMapper(typeof(DomainToDto), typeof(ViewModelToDomain));

builder.Services.AddValidatorsFromAssemblyContaining(typeof(CreateCategoryValidator));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
