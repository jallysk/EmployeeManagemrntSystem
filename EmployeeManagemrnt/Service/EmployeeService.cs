using EmployeeManagement.Shared;

namespace EmployeeManagemrnt.Service
{
    public class EmployeeService:BaseService<Employee>
    {
        public EmployeeService(ApplicationDbContext context):base(context) { 
        
        }
    }
}
