using Pararin.CareerAgent.Domain.Entities;
using Pararin.CareerAgent.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "Pararin AI-Agent");
app.MapControllers();

app.MapGet("/Person/{firstname}", (string firstName) =>
{
    return firstName;
});

app.Run();