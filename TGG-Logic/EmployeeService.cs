using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGG_DAL;
using TGG_Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace TGG_Logic
{
    public class EmployeeService
    {
        private EmployeeDAO employeeDAO;
        private TGGEncryption encryptionService;

        public EmployeeService()
        {
            employeeDAO = new EmployeeDAO();
            encryptionService = new TGGEncryption();
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.Password = encryptionService.HashWithSalt(employee.Password);
            return employeeDAO.AddEmployee(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDAO.GetAllEmployees();
        }

        public List<Employee> GetEmployeesByElement(BsonElement filterElement, params BsonElement[] extraFilterElement)
        {
            return employeeDAO.GetEmployeesByElement(filterElement, extraFilterElement);
        }

        public List<UpdateResult> UpdateEmployeeByElement(BsonElement filterElement, BsonElement updateElement, params BsonElement[] extraUpdateElements)
        {
            return employeeDAO.UpdateEmployeeByElement(filterElement, updateElement, extraUpdateElements);
        }

        public DeleteResult DeleteEmployeeByElement(BsonElement filterElement)
        {
            return employeeDAO.DeleteEmployeeByElement(filterElement);
        }
    }
}
