using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;


namespace YourNamespace
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Конфігурація сервісу логування в файл
            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddFile(options =>
                {
                    options.FileName = "Logs/myapp-{date:yyyyMMdd}.txt"; // Початок імені файлу
                    options.FileSizeLimitBytes = 10485760; // Розмір файлу (10MB)
                    options. = 5; // Ліміт збережених файлів
                    options.MaxQueueSize = 100; // Максимальний розмір черги
                });
            });

            // Додаткові конфігурації сервісів можна виконати тут
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // Налаштування для продуктивного середовища
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
