﻿using System;
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

        public EmployeeService()
        {
            employeeDAO = new EmployeeDAO();
        }

        public Employee AddEmployee(Employee employee)
        {
            return employeeDAO.AddEmployee(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDAO.GetAllEmployees();
        }

        public List<Employee> GetEmployeesByElement(BsonElement filterElement)
        {
            return employeeDAO.GetEmployeesByElement(filterElement);
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
