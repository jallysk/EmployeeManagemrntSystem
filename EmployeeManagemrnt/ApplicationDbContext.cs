using EmployeeManagement.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EmployeeManagemrnt
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
         //Emp
            public virtual DbSet<Employee> Employee {get; set;}
        //Dept
            public virtual DbSet<Department> Department {get; set;}   
                  

        
    }
}
