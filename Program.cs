using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WebEndpoint.Data;

var builder = WebApplication.CreateBuilder();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MainContext")));

builder.Services.AddFastEndpoints();
var app = builder.Build();

app.UseAuthorization();
app.UseFastEndpoints();
app.UseRouting();

app.UseSwaggerUI(c => c.SwaggerEndpoint("swagger", "SampleEndpointApp V1"));
app.UseHttpsRedirection();
app.Run();