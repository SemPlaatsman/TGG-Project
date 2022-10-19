using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGG_Model;

namespace TGG_Logic
{
    public class ResetPasswordService
    {
        public void InsertValidationCode(Validation validationUser)
        {

        }

        public List<Employee> AddEmployee(List<Employee> employees)
        {
            employees.ForEach(x => x.Password = encryptionService.HashWithSalt(x.Password));
            return employeeDAO.AddEmployee(employees);
        }
    }
}
