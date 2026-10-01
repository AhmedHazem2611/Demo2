using Microsoft.EntityFrameworkCore;
using QuizTwo.Models;
using QuizTwo.Repos.Interface;

namespace QuizTwo.Repos.Implementation
{
    public class VehicleRepo : GenericRepo<Vehicle>,IVehicleRepo
    {
        private readonly AppDbContext _context;
        public VehicleRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<Vehicle> GetAvailableVehicles()
        {
            return _context.Vehicles.Where(v => v.Status== "Available").ToList();
        }

        public IEnumerable<Vehicle> GetSoldVehicles()
        {
            return _context.Vehicles.Where(v => v.Status == "Sold").ToList();
        }

        public IEnumerable<Vehicle> GetVehiclesByCategory(string type)
        {
            return _context.Vehicles.Include(e => e.Category).Where(v => v.Category.Name == type).ToList();
        }
    }
}
