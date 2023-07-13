using BookAPI.Repository;
using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WebEndpoint.Data;
using WebEndpoint.Domain.Contracts;
using WebEndpoint.Endpoints.CatalogEndpoints.CatalogResult;
using WebEndpoint.Service;
using WebEndpoint.Service.Contracts;

var builder = WebApplication.CreateBuilder();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MainContext")));

builder.Services.AddLogging();
builder.Services.AddFastEndpoints();

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<ICatalog<Book, BookResult>, BookCatalogService>();


var app = builder.Build();


app.UseHttpLogging();
app.UseAuthorization();
app.UseFastEndpoints();
app.UseRouting();

app.UseSwaggerUI(c => c.SwaggerEndpoint("swagger", "SampleEndpointApp V1"));
app.UseHttpsRedirection();
app.Run();