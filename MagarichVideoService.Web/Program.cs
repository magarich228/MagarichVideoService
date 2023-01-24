var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllersWithViews();

var app = builder.Build();

app.MapControllers();

app.Run();
