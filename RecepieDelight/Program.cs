using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RecepieDelight.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RecepieDelightContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RecepieDelightContext") ?? throw new InvalidOperationException("Connection string 'RecepieDelightContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<RecepieDelightContext>();
    context.Database.EnsureCreated();
    // DbInitializer.Initialize(context);
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
