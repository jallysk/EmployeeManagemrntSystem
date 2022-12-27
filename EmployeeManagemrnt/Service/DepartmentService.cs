using EmployeeManagement.Shared;

namespace EmployeeManagemrnt.Service
{
    public class DepartmentService : BaseService<Department>
    {
        public DepartmentService(ApplicationDbContext context):base(context) {
        }
    }
  

   
}
