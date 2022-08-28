using Reactivities.Persistance;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Reactivities.Application.Activities;
using Reactivities.Application.Core;
using FluentValidation.AspNetCore;
using FluentValidation;
using Reactivities.API.Middleware;

const string corsPolicy = "CorsPolicy";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ReactivitiesDataContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddCors(opt => {
    opt.AddPolicy(name: corsPolicy, policy =>
    {
        policy
        .AllowAnyHeader()
        .AllowAnyMethod()
        .WithOrigins("http://localhost:3000");
    });
});

builder.Services.AddMediatR(typeof(List.Handler).Assembly);
builder.Services.AddAutoMapper(typeof(MappingProfiles).Assembly);

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllers();
//    .AddFluentValidation(config => {
//        config.RegisterValidatorsFromAssemblyContaining<Create>();
//    });
builder.Services.AddFluentValidationAutoValidation()
    .AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<Create>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();
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
