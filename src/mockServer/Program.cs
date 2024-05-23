using Microsoft.AspNetCore.Mvc;
using MockServer.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => 
{
    var docFile = $"{typeof(Program).Assembly.GetName().Name}.xml";

    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, docFile));    
    
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(o => 
{
    o.SwaggerEndpoint("/swagger/v1/swagger.json", "MockServer API");
    o.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.MapOpenApi();

app.Run();