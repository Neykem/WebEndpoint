using FastEndpoints;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder();

builder.Services.AddFastEndpoints();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
//    c.EnableAnnotations();
//});

var app = builder.Build();

app.UseAuthorization();
app.UseFastEndpoints();
app.UseRouting();

app.UseSwaggerUI(c => c.SwaggerEndpoint("swagger", "SampleEndpointApp V1"));
app.UseHttpsRedirection();
app.Run();