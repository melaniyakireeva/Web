using _1.Models;
using Microsoft.EntityFrameworkCore;

namespace _1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            #if DEBUG
            builder.Services.AddSassCompiler();
            #endif

            // Подключение базы данных SQL Server или PostgreSQL
            string connection = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<CakesContext>(options => options.UseSqlServer(connection));
            //builder.Services.AddDbContext<SampleAppContext>(options => options.UseNpgsql(connection));

            builder.Services.AddFlashes();

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
        }
    }
}