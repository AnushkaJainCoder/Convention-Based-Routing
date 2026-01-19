using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

// app.MapDefaultControllerRoute();

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=About}/{id?}"
// );


app.MapControllers();

// app.MapGet("/", () => "Hello World!");

// app.Use(async(context, next) => {
//     await context.Response.WriteAsync("Hello from Middleware!");
//     await next(context);
// });

// app.Use(async(context, next)=> {
//     await context.Response.WriteAsync("This will not be executed.");
//     await next(context);
// });

app.Run();
