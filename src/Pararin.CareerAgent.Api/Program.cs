using Pararin.CareerAgent.Domain.Entities;
using Pararin.CareerAgent.Infrastructure;
using Pararin.CareerAgent.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "Pararin AI-Agent");
app.MapControllers();

app.Run();