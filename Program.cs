using System;

var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
   name: "default",
   pattern: "{controller = Home}/ {action = Index}/ {id?}"
);
app.Run();

// app.Use(async(context, next) => {
//     await context.Response.WriteAsync("Hello from Middleware!");
//     await next(context);
// });

// app.Use(async(context, next)=> {
//     await context.Response.WriteAsync("This will not be executed.");
//     await next(context);
// });

// delegates
// app.MapGet("/", () => "hello");
// app.MapGet("/home", () => "get ");
// app.MapPost("/home", () => "post");
// app.MapPut("/home", () => "put");
// app.MapDelete("/home", () => "delete");


// app.UseRouting();
// app.UseEndpoints(endpoint =>
// {
//     endpoint.MapGet("/home", async (context) =>
//     {
//        await context.Response.WriteAsync("home page get");
//     });
//     endpoint.MapPost("/home", async (context) =>
//     {
//        await context.Response.WriteAsync("home page post");
//     });
// });

// app.Run(async(HttpContext context) => {
//    await context.Response.WriteAsync("page not found");
// } );
