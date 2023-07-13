//using EduSamaV4.Services;

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

//builder.Services.AddDistributedMemoryCache();
//builder.Services.AddSession(options =>""
//{
//    options.IdleTimeout = TimeSpan.FromHours(10);
//});

//builder.Services.AddTransient<LanguageService>();

//var app = builder.Build();

//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    app.UseHsts();
//}
//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();
//app.UseAuthorization();
//app.UseSession();
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Uyelik}/{action=Giris}/{id?}");
//app.Run();

using EduSamaV4.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
	options.IdleTimeout = TimeSpan.FromHours(10);
});

builder.Services.AddTransient<LanguageService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession();
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Uyelik}/{action=Giris}/{id?}");

app.Run();
