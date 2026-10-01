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
        public int GetTotalRevenue()
        {
            int totalRevenue = 0;
            return _context.Sales.Aggregate(totalRevenue, (acc, sale) => ((int)(acc + sale.SalePrice)));
        }
    }
}
