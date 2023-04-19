using BLL.Services.Abstract;
using DataAccess;
using DataAccess.Context;
using Entity.Models;
using Entity.PModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Concrete
{
    public class LoginService : ILoginService
    {
        public Employee? Login(Login login)
        {
            using(IUnitOfWork _unit = new UnitOfWork(new PersonelDbContext()))
            {
                var Employee = _unit.EmployeeRepository.GetEmployeeByEmail(login.Email);
                if(Employee is not null && Employee.Pass.Equals(login.Pass)) 
                {
                    return Employee; 
                }
                return null;
            }
        }
    }
}
