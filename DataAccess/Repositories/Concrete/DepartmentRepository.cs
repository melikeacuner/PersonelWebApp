using DataAccess.Context;
using DataAccess.Repositories.Abstract;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(PersonelDbContext dbContext) : base(dbContext)
        {
        }

        public PersonelDbContext PersonelContext { get { return (PersonelDbContext)dbContext; } }
        public List<Employee> GetAllEmployeesUnderDepartment(int depid)
        {
            using (PersonelContext)
            {
                var Department = PersonelContext.Departments.Include("Employees").FirstOrDefault(d => d.Id == depid);
                var Employees = Department.Employees;
                return Employees;

            }
        }
    }
}
