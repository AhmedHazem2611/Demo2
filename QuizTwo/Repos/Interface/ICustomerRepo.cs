using QuizTwo.Models;

namespace QuizTwo.Repos.Interface
{
    public interface ICustomerRepo: IGenericRepo<Customer>
    {
        public IEnumerable<Sale> GetCustomerPurchaseHistory(int id);
    }
}
