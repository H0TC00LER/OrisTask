using Microsoft.EntityFrameworkCore;
using Persistance;
using Microsoft.Extensions.FileProviders;
using Services.Contracts;
using Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services
    .AddDbContext<AppDbContext>(options => options.UseSqlServer(connString, b => b.MigrationsAssembly("OrisTask")));

builder.Services.AddScoped<IImageService>(x => new ImageService(builder.Configuration["ImagePath"]));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
                Path.Combine(builder.Environment.ContentRootPath, "wwwroot")),
    RequestPath = "",
    OnPrepareResponse = ctx =>
    {
        // Устанавливаем заголовки кэширования для статических файлов
        ctx.Context.Response.Headers["Cache-Control"] = "no-cache, no-store";
        ctx.Context.Response.Headers["Pragma"] = "no-cache";
        ctx.Context.Response.Headers["Expires"] = "-1";
    }
});

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
