using Microsoft.EntityFrameworkCore;
using Persistance;
using Microsoft.EntityFrameworkCore.Design;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services
    .AddDbContext<AppDbContext>(options => options.UseSqlServer(connString, b => b.MigrationsAssembly("OrisTask")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();