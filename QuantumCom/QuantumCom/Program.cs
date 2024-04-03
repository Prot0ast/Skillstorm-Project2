using Microsoft.AspNetCore.HttpOverrides;
using QuantumCom.Extensions;
using NLog;
using Contracts;
using QuantumCom;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.Formatters;

var builder = WebApplication.CreateBuilder(args);

LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/Nlog.config"));

// Add services to the container.
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddControllers();
builder.Services.ConfigureLoggerService();

var app = builder.Build();
app.UseExceptionHandler(opt => { });

// Configure the HTTP request pipeline.
if (app.Environment.IsProduction())
    app.UseHsts();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();