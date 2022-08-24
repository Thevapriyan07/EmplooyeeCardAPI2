using Microsoft.EntityFrameworkCore;

namespace EmplooyeeCardAPI2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<EmployeeCard> Employees => Set<EmployeeCard>();
    }
}
