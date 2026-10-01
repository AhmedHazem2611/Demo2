using QuizTwo.Models;

namespace QuizTwo.Repos.Interface
{
    public interface IUnitOfWork
    {
        IVehicleRepo Vehicle { get; }
        ICustomerRepo Customer { get; }
        IEmployeeRepo Employee { get; }
        ISalesRepo Sale { get; }
        IGenericRepo<Category> Category { get; }
        IGenericRepo<CustomerProfile> CustomerProfile { get; }
        void Save();

    }
}
