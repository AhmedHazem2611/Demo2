using QuizTwo.Models;

namespace QuizTwo.Repos.Interface
{
    public interface IVehicleRepo : IGenericRepo<Vehicle>
    {
        public IEnumerable<Vehicle> GetAvailableVehicles();
        public IEnumerable<Vehicle> GetSoldVehicles();
        public IEnumerable<Vehicle> GetVehiclesByCategory(string type);
    }
}
