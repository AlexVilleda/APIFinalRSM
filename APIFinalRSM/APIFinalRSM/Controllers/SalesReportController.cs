
using APIFinalRSM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIFinalRSM.Controllers
{
    public class SalesReportController : Controller
    {
        [HttpGet]
        [Route("reports")]
        public async Task<IActionResult> GetSalesReport([FromQuery] DateTime? startDate, [FromQuery] DateTime? endDate,
                                                 [FromQuery] string productCategory = null)
        {
            using (var context = new SalesReportContext())
            {
                var query = context.SalesReports.AsQueryable(); // Start with all reports

                // Apply filters based on provided parameters
                if (startDate.HasValue)
                {
                    query = query.Where(report => report.OrderDate >= startDate);
                }

                if (endDate.HasValue)
                {
                    query = query.Where(report => report.OrderDate <= endDate);
                }

                if (!string.IsNullOrEmpty(productCategory))
                {
                    query = query.Where(report => report.ProductCategory == productCategory);
                }

                var reports = await query.ToListAsync();
                return Ok(reports); // Return filtered reports as JSON
            }
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
