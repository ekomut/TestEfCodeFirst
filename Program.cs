using Microsoft.EntityFrameworkCore;
using TestEfCodeFirst;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>(options =>
                options
                    .UseNpgsql("Server=10.160.229.190;Port=5432;Database=metric;User Id=metric_owner;Password=78787888;SearchPath=efcoretest;Pooling=true;Integrated Security=true;")
            .UseSnakeCaseNamingConvention()
                    );
    
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

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
