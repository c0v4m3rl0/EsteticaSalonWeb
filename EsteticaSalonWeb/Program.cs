using EsteticaSalonWeb.Components;
using Microsoft.EntityFrameworkCore;
using EsteticaSalonWeb.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add services to the containerhttps://api-udec-pweb.azurewebsites.net/
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Registrar el HttpClient apuntando a la URL base de la API del profesor
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://api-udec-pweb-aedec9hxbugye0am.westus3-01.azurewebsites.net/")
});

// Registrar nuestro servicio personalizado de la API
builder.Services.AddScoped<SaludApiService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
