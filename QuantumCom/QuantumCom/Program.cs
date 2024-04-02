using Microsoft.AspNetCore.HttpOverrides;
using QuantumCom.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddControllers();

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
