using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGG_DAL;
using TGG_Model;

namespace TGG_Logic
{
    public class EmployeeService
    {
        private EmployeeDAO employeeDAO;

        public EmployeeService()
        {
            employeeDAO = new EmployeeDAO();
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDAO.GetAllEmployees();
        }
    }
}
