using DigitalWorldHub.Infrastructure;
using DigitalWorldHub.Application;
using DigitalWorldHub.Server.Middleware;
using DigitalWorldHub.Core.Entities.User;
using DigitalWorldHub.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.AddIdentityCore<AppUser> (options =>
{
    options.Password.RequiredLength = 6;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;

}).AddEntityFrameworkStores<StoreContext>()
  .AddSignInManager<SignInManager<AppUser>>()
  .AddUserManager<UserManager<AppUser>>()
  .AddDefaultTokenProviders();


builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolice", policy =>
    {
        policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200");
    });
});
var app = builder.Build();
app.UseRouting();
app.UseDefaultFiles();

app.UseStaticFiles();

// Configure the HTTP request pipeline.
app.UseMiddleware<ExceptionMiddleware>();

app.UseSwagger();

app.UseSwaggerUI();

app.UseStatusCodePagesWithReExecute("/errors/{0}");

app.UseHttpsRedirection();
app.UseCors("CorsPolice");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("Index", "Fallback");

app.Run();
