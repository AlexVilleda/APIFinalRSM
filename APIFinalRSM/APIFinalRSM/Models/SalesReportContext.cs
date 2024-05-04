using Microsoft.EntityFrameworkCore;

namespace APIFinalRSM.Models
{
    public class SalesReportContext : DbContext
    {
        public SalesReportContext()
        {
        }

        public SalesReportContext(DbContextOptions<SalesReportContext> options) : base(options) { }

        // Define DbSet properties for your entities (e.g., SalesReport)
        public DbSet<SalesReport> SalesReports { get; set; }
    }
}
