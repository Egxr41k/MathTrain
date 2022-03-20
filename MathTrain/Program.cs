var builder = WebApplication.CreateBuilder(args);
//IConfiguration config { get; }


//connect services
builder.Services.AddControllersWithViews(); // MVC support

//do the assembly
var app = builder.Build();


if (app.Environment.IsDevelopment()) app.UseDeveloperExceptionPage();

app.UseRouting();

app.UseStaticFiles(); //css & js support 

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        "default", "{controller=Home}/{action=Index}/{id?}");
});

//app.MapGet("/", () => "Hello World!");

app.Run();
