using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("SqliteConnection");
builder.Services.AddDbContext<Context>(options => options.UseSqlite(connectionString));


//// ilk bu çaðýralacak bakýcak ki productManager'da da bir inject iþlemi var IProductRepository istiyor hangisi ama DapperProductRepo mu EfCoreProductrepo mu gitmeli ?
builder.Services.AddScoped<IProductService, ProductManager>();
//Burada da kardeþim benden ýProductRepo istiyorsan benden ben sana EfCoreProductRepo göndericem Demek
//? builder.Services.AddScoped<IProductRepository, EfCoreProductRepository>(); UnitOfWork eklediðimiz için bune gerek kalmadý
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddControllersWithViews();



//var configuration = new ConfigurationBuilder()
//    .SetBasePath(AppContext.BaseDirectory)
//    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//    .Build();

//builder.Services.AddDbContext<Context>(options =>
//{
//    var connectionString = configuration.GetConnectionString("SqliteConnection");
//    options.UseSqlite(connectionString);
//});
//builder.Services.AddScoped<DbContext, Context>();


var mvcBuilder = builder.Services.AddRazorPages();

if (builder.Environment.IsDevelopment())
{
    mvcBuilder.AddRazorRuntimeCompilation();
}

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
