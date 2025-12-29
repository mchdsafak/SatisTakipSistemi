using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SatisTakipSistemi.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SatisTakipSistemiContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SatisTakipSistemiContext") ?? throw new InvalidOperationException("Connection string 'SatisTakipSistemiContext' not found.")));

builder.Services.AddControllersWithViews();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<SatisTakipSistemiContext>();
    db.Database.Migrate();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
