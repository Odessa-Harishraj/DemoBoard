using Microsoft.EntityFrameworkCore;
using JiraClone.Data;

var builder = WebApplication.CreateBuilder(args);

// =========================
// Register Services
// =========================

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions =>
        {
            // Enable retry on transient failures (e.g., network blips, timeouts)
            sqlOptions.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
        }));

// =========================
// Build App
// =========================

var app = builder.Build();

// =========================
// Configure Middleware
// =========================

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Remove HSTS to allow plain HTTP when hosting behind IIS with IP access
    // app.UseHsts();
}

// Remove HTTPS redirection to allow access over HTTP by IP when hosted in IIS
// app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// =========================
// Route Mapping
// =========================

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
