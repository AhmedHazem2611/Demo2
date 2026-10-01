using QuizTwo.Models;
using QuizTwo.Repos.Interface;

namespace QuizTwo.Repos.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        public IVehicleRepo Vehicle { get;}

        public ICustomerRepo Customer { get; }

        public IEmployeeRepo Employee { get; }

        public ISalesRepo Sale { get; }

        public IGenericRepo<Category> Category { get; }

        public IGenericRepo<CustomerProfile> CustomerProfile { get;}

        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context, IVehicleRepo vehicle, ICustomerRepo customer, IEmployeeRepo employee, ISalesRepo sale, IGenericRepo<Category> category, IGenericRepo<CustomerProfile> customerProfile)
        {
            _context = context;
            Vehicle = vehicle;
            Customer = customer;
            Employee = employee;
            Sale = sale;
            Category = category;
            CustomerProfile = customerProfile;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
