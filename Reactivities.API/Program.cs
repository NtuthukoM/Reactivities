using Reactivities.Persistance;
using Microsoft.EntityFrameworkCore;

const string corsPolicy = "CorsPolicy";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ReactivitiesDataContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddCors(opt => {
    opt.AddPolicy(name: corsPolicy, policy =>
    {
        policy.WithOrigins("http://localhost:3000");
    });
});

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseRouting();
app.UseCors(corsPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();
