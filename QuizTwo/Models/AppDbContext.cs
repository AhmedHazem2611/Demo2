using Microsoft.EntityFrameworkCore;

namespace QuizTwo.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerProfile> CustomerProfiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Vehicles)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Sales)
                .WithOne(p => p.Customer)
                .HasForeignKey(p => p.CustomerId);
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Sales)
                .WithOne(p => p.Employee)
                .HasForeignKey(p => p.EmployeeId);
            modelBuilder.Entity<Vehicle>()
                .HasOne(p => p.Sale)
                .WithOne(s => s.Vehicle)
                .HasForeignKey<Vehicle>(s => s.SaleId);
            modelBuilder.Entity<Customer>()
                .HasOne(p => p.CustomerProfile)
                .WithOne(s => s.Customer)
                .HasForeignKey<Customer>(s => s.CustomerProfileId);

            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Email)
                .IsUnique();
            modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();
            modelBuilder.Entity<Vehicle>()
                .HasIndex(v => v.VIN)
                .IsUnique();
            modelBuilder.Entity<Customer>()
                .HasIndex(p => p.DriverLicenseNumber)
                .IsUnique();
            modelBuilder.Entity<Employee>()
                .HasIndex(p => p.Email)
                .IsUnique();
            modelBuilder.Entity<Vehicle>()
                .Property(v => v.Price)
                .HasPrecision(12, 2);
            modelBuilder.Entity<Sale>()
                .Property(s => s.SalePrice)
                .HasPrecision(12, 2);
            modelBuilder.Entity<Vehicle>()
                .Property(v => v.Status)
                .HasDefaultValue("Available");

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category { Id = 1, Name = "Sedan" , Description ="a"},
                    new Category { Id = 2, Name = "SUV", Description = "b" },
                    new Category { Id = 3, Name = "Hatchback", Description = "c" }
                );
            modelBuilder.Entity<Vehicle>()
                .HasData(
                    new Vehicle { Id = 1, Make = "Toyota", Model = "Camry", Year = 2020, Price = 25000, VIN = "1Hfosdjf", CategoryId = 1 , FuelType="petrol", Status="Sold" , Transmission="Automatic", SaleId=1, Color="blue"},
                    new Vehicle { Id = 2, Make = "Honda", Model = "Civic", Year = 2019, Price = 20000, VIN = "2Hfosdjf", CategoryId = 2, FuelType = "petrol", Status = "Sold", Transmission = "Automatic", SaleId=2, Color="blue"},
                    new Vehicle { Id = 3, Make = "Ford", Model = "Focus", Year = 2018, Price = 18000, VIN = "3Hfosdjf", CategoryId = 3, FuelType = "petrol", Status = "Sold", Transmission = "Automatic" , SaleId = 3, Color="blue" }
                    );
            modelBuilder.Entity<Customer>()
                .HasData(
                    new Customer { Id = 1, Name = "Ahmed Hassan", Email = "ahmed@gamil.com", PhoneNumber = "1234567890", DriverLicenseNumber = "D1234567", CustomerProfileId=1 },
                    new Customer { Id = 2, Name = "Ali Ahmed", Email = "ali@gmail.com", PhoneNumber = "0987654321", DriverLicenseNumber = "D7654321", CustomerProfileId=2 },
                    new Customer { Id = 3, Name = "Sara Ali", Email = "sara@gmail.com", PhoneNumber = "1122334455", DriverLicenseNumber = "D1122334" , CustomerProfileId = 3 }
                    );
            modelBuilder.Entity<CustomerProfile>()
                .HasData(
                    new CustomerProfile { Id = 1, Address = "123 Main St", City = "New York", Nationality="Egyptian", DateOfBirth=DateTime.Now },
                    new CustomerProfile { Id = 2, Address = "456 Elm St", City = "Los Angeles", Nationality = "Egyptian", DateOfBirth = DateTime.Now },
                    new CustomerProfile { Id = 3, Address = "789 Oak St", City = "Chicago", Nationality = "Egyptian", DateOfBirth = DateTime.Now },
                    new CustomerProfile { Id = 4, Address = "321 Pine St", City = "Houston", Nationality = "Egyptian", DateOfBirth = DateTime.Now }
                    );
            modelBuilder.Entity<Employee>()
                .HasData(
                    new Employee { Id = 1, FullName = "John Doe", Email = "jogn@mai.com" , PhoneNumber = "555-1234" , Position="Sales Manager", HireDate=DateTime.Now},
                    new Employee { Id = 2, FullName = "Jane Smith", Email = "horg@gmail.com" , PhoneNumber = "555-5678", Position = "Sales Associate", HireDate = DateTime.Now },
                    new Employee { Id = 3, FullName = "Michael Johnson", Email = "mich@gmail.om" , PhoneNumber = "555-9012", Position = "Sales Representative",HireDate = DateTime.Now }
                    );
            modelBuilder.Entity<Sale>()
                .HasData
                (
                    new Sale { Id = 1, CustomerId = 1, EmployeeId = 1, SalesDate = DateTime.Now, SalePrice = 24000, PaymentMethod="Visa" },
                    new Sale { Id = 2, CustomerId = 2, EmployeeId = 2, SalesDate = DateTime.Now, SalePrice = 19000 , PaymentMethod = "Visa" },
                    new Sale { Id = 3, CustomerId = 3, EmployeeId = 3, SalesDate = DateTime.Now, SalePrice = 17000 , PaymentMethod = "Visa" }
                );
        }
    }
}
