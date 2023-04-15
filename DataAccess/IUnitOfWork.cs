using DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IUnitOfWork : IDisposable 
    {
        IActivityRepository ActivityRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        INotificationRepository  NotificationRepository { get; }
        IPermitRepository PermitRepository { get; }
        int Complete();
    }
}
