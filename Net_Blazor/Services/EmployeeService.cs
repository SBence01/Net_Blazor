using Net_Blazor.Shared;

namespace Net_Blazor.Services
{
    public class EmployeeService : ServiceBase<Employee>
    {
        public EmployeeService(ApplicationDbContext context) : base(context)
        {

        }
    }
}
