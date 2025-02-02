using Microsoft.EntityFrameworkCore;
using Quiz_platform_User.BL.Managers.Quizzes;
using Quiz_platform_User.DAL.Models;
using Quiz_platform_User.DAL.Repositories.QuizRepostository;
using Quiz_platform_User.DAL.UnitOfWork;

namespace Quiz_platform_User
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var connectionString = builder.Configuration.GetConnectionString("QuizDb");

            builder.Services.AddDbContext<QuizSystemContext>(options =>
               options.UseSqlServer(connectionString));

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IQuizRepository, QuizRepository>();
            builder.Services.AddScoped<IQuizManager, QuizManager>();

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
                pattern: "{controller=Quizzes}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
