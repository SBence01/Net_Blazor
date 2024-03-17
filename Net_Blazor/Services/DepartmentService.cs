using Net_Blazor.Shared;

namespace Net_Blazor.Services
{
    public class DepartmentService : ServiceBase<Department>
    {
        public DepartmentService(ApplicationDbContext context) : base(context)
        {

        }
    }
}
