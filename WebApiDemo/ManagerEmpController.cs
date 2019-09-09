using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo
{
    public class ManagerEmpController
    {
        public static void SelectManager(Employee manager, Employee emp)
        {
            if (ManagerEmpController.IsValidManager(manager))
            {
                try
                {
                    Manager.ManagerEmpList[manager].Add(emp);
                }
                catch (KeyNotFoundException)
                {
                    Manager.ManagerEmpList.Add(manager, new List<Employee>() { emp });
                }
            }
            else
                throw new Exception("selelcted employee is not a valid manager");
        }
        public static bool IsValidManager(Employee manager)
        {
            if (manager.EmpPost == "manager")
                return true;
            else
                return false;
        }
    }
}
