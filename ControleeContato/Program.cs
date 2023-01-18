using ControleeContato.Data;
using ControleeContato.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

var connstring = builder.Configuration.GetConnectionString("DataBase") ?? "";
var serverversion = ServerVersion.AutoDetect(connstring);

builder.Services.AddDbContext<BancoContext>(opt =>
{
    opt
        .UseMySql(connstring, serverversion)
        .LogTo(Console.WriteLine)
        .EnableDetailedErrors()
        .EnableSensitiveDataLogging();
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
