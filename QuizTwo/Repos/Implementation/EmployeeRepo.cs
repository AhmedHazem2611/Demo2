using Microsoft.EntityFrameworkCore;
using QuizTwo.Models;
using QuizTwo.Repos.Interface;

namespace QuizTwo.Repos.Implementation
{
    public class EmployeeRepo : GenericRepo<Employee>, IEmployeeRepo
    {
        private readonly AppDbContext _context;
        public EmployeeRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<Sale> GetEmployeeSalesStat(int id)
        {
            return _context.Sales.Where(s => s.CustomerId == id).ToList();
        }
    }
}
