using Reactivities.Persistance;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Reactivities.Application.Activities;
using Reactivities.Application.Core;
using FluentValidation.AspNetCore;
using FluentValidation;
using Reactivities.API.Middleware;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Reactivities.Domain;
using Reactivities.API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Reactivities.Application.Interfaces;
using Infrastructure.Security;
using Infrastructure.Photos;

const string corsPolicy = "CorsPolicy";
var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

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

builder.Services.AddDefaultIdentity<AppUser>(options => {
    options.Password.RequireNonAlphanumeric = false;
})
    //.AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ReactivitiesDataContext>();

var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"]));
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opt => {
        opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true,
            ValidateIssuer = false,
            IssuerSigningKey = key,
            ValidateAudience = false
        };
    });

builder.Services.AddAuthorization(opt =>
{
    opt.AddPolicy("IsHostRequirement", policy =>
    {
        policy.Requirements.Add(new IsHostRequirement());
    });
});

builder.Services.AddTransient<IAuthorizationHandler, IsHostRequirementHandler>();
builder.Services.AddScoped<TokenService>();
builder.Services.AddScoped<IUserAccessor, UserAccessor>();
builder.Services.AddScoped<IPhotoAccessor, PhotoAccessor>();
builder.Services.AddMediatR(typeof(List.Handler).Assembly);
builder.Services.AddAutoMapper(typeof(MappingProfiles).Assembly);
builder.Services.Configure<CloudinarySettings>(config.GetSection("Cloudinary"));

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//All controllers require authentication by default
builder.Services.AddControllers(opt => {
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser().Build();
    opt.Filters.Add(new AuthorizeFilter(policy));
});
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
