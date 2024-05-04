using APIFinalRSM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace APIFinalRSM
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
            services.AddDbContext<SalesReportContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // ... other service registrations

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sales Report API", Version = "v1" });
            });
        }
    }
}
