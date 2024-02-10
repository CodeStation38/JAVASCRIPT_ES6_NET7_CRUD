using Microsoft.EntityFrameworkCore;

namespace JSwebapiCRUD.Models
{
    public class DepartmentContext: DbContext
    {
      public DepartmentContext(DbContextOptions<DepartmentContext> options)
    : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; } = null!;

    }
}
