using BLL.Services.Abstract;
using DataAccess;
using DataAccess.Context;
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
        public bool Login(Login login)
        {
            using(IUnitOfWork _unit = new UnitOfWork(new PersonelDbContext()))
            {
                var Employee = _unit.EmployeeRepository.GetByExpression(e => e.Email.Equals(login.Email));
                if(Employee.Pass.Equals(login.Pass)) 
                {
                    return true; 
                }
                return false;
            }
        }
    }
}
