using Microsoft.EntityFrameworkCore;
using WeddingServer.DbContext;
using WeddingServer.Services.TelegramService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextFactory<PostgreDBContext>(options =>
{
    options.UseNpgsql("Server=localhost;Database=wedding;Port=5432;UserId=postgres;Password=94monizi;");
});
builder.Services.AddHostedService<TelegramService>();
builder.Services.AddScoped<TelegramServiceSingleton>();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("AllowSpecificOrigin");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
