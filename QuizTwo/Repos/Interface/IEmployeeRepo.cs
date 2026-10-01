using QuizTwo.Models;

namespace QuizTwo.Repos.Interface
{
    public interface IEmployeeRepo : IGenericRepo<Employee>
    {
        public IEnumerable<Sale> GetEmployeeSalesStat(int id);
    }
}
