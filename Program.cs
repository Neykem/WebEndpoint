using Microsoft.OpenApi.Models;
using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
    c.EnableAnnotations();
});


builder.Services.AddFastEndpoints();

var app = builder.Build();

app.UseAuthentication();
app.UseFastEndpoints();
app.UseRouting();

app.UseSwaggerUI(c => c.SwaggerEndpoint("swagger", "SampleEndpointApp V1"));
app.UseHttpsRedirection();
app.Run();
