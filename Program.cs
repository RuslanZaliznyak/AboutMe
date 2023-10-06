
var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts(); 
}

DotNetEnv.Env.TraversePath().Load();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.Use(async (context, next) =>
{
    string yourIpAddress = "188.146.116.22";
    string remoteIpAddress = context.Connection.RemoteIpAddress.ToString();

    if (remoteIpAddress == yourIpAddress)
    {
        await next.Invoke();
    }
    else
    {
        if (context.Request.Path == "/Blog/Add")
        {
            context.Response.StatusCode = 403;
            await context.Response.WriteAsync("Access is denied");
        }
        else
        {
            await next.Invoke();
        }
    }
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=AboutMe}/{id?}");

app.Run();

