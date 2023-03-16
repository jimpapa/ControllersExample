using ControllersExample.Controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); //adds all the controller classes as services

//builder.Services.AddTransient<HomeController>();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllers();   
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});
app.Run();
