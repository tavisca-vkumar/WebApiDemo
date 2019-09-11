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
        
        public static Dictionary<Employee, List<Employee>> ManagerEmpList = new Dictionary<Employee, List<Employee>>();

        public static List<Employee> GetManagerList()
        {
            var managers = new List<Employee>();
            foreach(var itr in ManagerEmpList)
            {
                managers.Add(itr.Key);
            }
            return managers;
        }


        public static bool IsValidManager(int id)
        {
            foreach (var emp in Employee.EmployeesList)
            {
                if (emp.ID == id && emp.EmpPost == "manager")
                    return true;
            }
            return false;
        }


        public static Employee GetManagerById(int id)
        {

            //foreach(var manager in Manager.ManagerEmpList)
            //{
            //    if (manager.Key.ID == id)
            //        return manager.Key;
            //}
            foreach(var manager in Employee.EmployeesList)
            {
                if (manager.ID == id)
                    return manager;
            }
            throw new Exception("no Manager Found");
        }
        

    }
}
