using QuizTwo.Models;

namespace QuizTwo.Repos.Interface
{
    public interface ISalesRepo: IGenericRepo<Sale>
    {
        public int GetTotalRevenue();
        public IEnumerable<Sale> GetSalesWithDetails();
    }
}
