using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Klassen
{

    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Andere Service-Konfigurationen
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Middleware-Konfigurationen
        }
    }
}
