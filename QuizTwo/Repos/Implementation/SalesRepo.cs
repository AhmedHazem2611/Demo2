using Microsoft.EntityFrameworkCore;
using QuizTwo.Models;
using QuizTwo.Repos.Interface;

namespace QuizTwo.Repos.Implementation
{
    public class SalesRepo : GenericRepo<Sale>, ISalesRepo
    {
        private readonly AppDbContext _context;
        public SalesRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<Sale> GetSalesWithDetails()
        {
            return _context.Sales.Include(e => e.Employee).Include(c => c.Customer).Include(v => v.Vehicle).ToList();
        }
        public int GetTotalRevenue()
        {
            int totalRevenue = 0;
            return _context.Sales.Aggregate(totalRevenue, (acc, sale) => ((int)(acc + sale.SalePrice)));
        }
    }
}
