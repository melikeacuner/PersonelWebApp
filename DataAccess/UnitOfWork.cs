using DataAccess.Context;
using DataAccess.Repositories.Abstract;
using DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private PersonelDbContext _context;
        public UnitOfWork(PersonelDbContext context)
        {
            _context = context;
            ActivityRepository = new ActivityRepository(_context);
            DepartmentRepository = new DepartmentRepository(_context);
            EmployeeRepository = new EmployeeRepository(_context);
            NotificationRepository = new NotificationRepository(_context);
            PermitRepository = new PermitRepository(_context);
        }

        public IActivityRepository ActivityRepository { get; private set; }
        public IDepartmentRepository DepartmentRepository { get; private set; }
        public IEmployeeRepository EmployeeRepository { get; private set; }
        public INotificationRepository NotificationRepository { get; private set; }
        public IPermitRepository PermitRepository { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
