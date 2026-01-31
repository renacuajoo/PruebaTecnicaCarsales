using BackEnd.Clients;
using BackEnd.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddHttpClient<IRickAndMortyClient, RickAndMortyClient>();
builder.Services.AddScoped<IEpisodesService, EpisodesService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});


var app = builder.Build();

app.MapControllers();
app.UseCors("AllowAngular");
app.Run();
