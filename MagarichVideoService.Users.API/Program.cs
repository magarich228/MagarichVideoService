using MagarichVideoService.Users.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

var services = builder.Services;

services.AddControllers();

services.AddEntityFrameworkNpgsql();
services.AddDbContext<UsersContext>(options => options.UseNpgsql(configuration.GetConnectionString("Postgre")));

var app = builder.Build();

app.MapControllers();

app.Run();