using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo
{
    public class Manager
    {
        string Name;
        int ID;
        int Salary;
        int Age;
        //public Manager(Employee emp)
        //{
        //    Name = emp.Name;
        //}
        //List<KeyValuePair<int, string>> EmployeesUnderManager = new List<KeyValuePair<int, string>>() ;

        
        public static Dictionary<Employee, List<Employee>> ManagerEmpList = new Dictionary<Employee, List<Employee>>();

        //List<Employee> EmployeesUnderManager = new List<Employee>()
        //{
        //    new Employee("ram", 3, 5000, 23, "employee"),
        //    new Employee("shyam", 4, 500, 23, "employee")
        //};

        //bool CheckEmpPresent(Employee employee)
        //{
        //    foreach(Employee emp in EmployeesUnderManager)
        //    {
        //        if (employee.ID == emp.ID)
        //            return true;
        //    }
        //    return false;
        //}
        //public void SelectEmployee(Employee emp)
        //{
        //    if(!CheckEmpPresent(emp))
        //    {
        //        EmployeesUnderManager.Add((emp));
        //    }
        //}
        
    }
}
