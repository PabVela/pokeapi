

using Pokedexx.Application;
using Pokedexx.Infraestructure.MySql.EntityFramework;
using Pokedexx.Infraestructure.MySql.QueryService;

var builder = WebApplication.CreateBuilder(args);


builder.Configuration
    .AddJsonFile($"appsettings.json", optional: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient("pokeapi", (options) =>
{
    options.BaseAddress = new Uri(builder.Configuration["pokeApi"]!); //
    //options.DefaultRequestHeaders.Add("Authorization","TOKEN")
});
builder.Services.AddDatabaseMySql(builder.Configuration);
builder.Services.AddQueryService();
builder.Services.AddApplication();
//Añadimos nuestros servicios 
//builder.Services.AddMySQLServices(this IServicesCollection services);

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
