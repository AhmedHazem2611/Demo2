using Microsoft.EntityFrameworkCore;
using QuizTwo.Models;
using QuizTwo.Repos.Interface;

namespace QuizTwo.Repos.Implementation
{
    public class CustomerRepo : GenericRepo<Customer>, ICustomerRepo
    {
        private readonly AppDbContext _context;
        public CustomerRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Sale> GetCustomerPurchaseHistory(int id)
        {
           return _context.Sales.Where(s => s.CustomerId == id).ToList();
        }
    }
}