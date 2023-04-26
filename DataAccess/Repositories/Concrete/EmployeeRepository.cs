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
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(PersonelDbContext dbContext) : base(dbContext)
        {
        }
        public PersonelDbContext PersonelContext { get { return (PersonelDbContext)dbContext; } }

        public Employee GetEmployeeByEmail(string Email)
        {
            var per = PersonelContext.Employees.FirstOrDefault(p => p.Email.Equals(Email));
            return per;
        }
    }
}
