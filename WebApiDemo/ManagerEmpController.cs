using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo
{
    public class ManagerEmpController
    {
        public static void SelectManager(int id, Employee emp)
        {
            if (Manager.IsValidManager(id))
            {
                try
                {
                    Manager.ManagerEmpList[Manager.GetManagerById(id)].Add(emp);
                }
                catch (KeyNotFoundException)
                {
                    Manager.ManagerEmpList.Add(Manager.GetManagerById(id), new List<Employee>() { emp });
                }
            }
            else
                throw new Exception("selelcted employee is not a valid manager");
        }


        //public static void SelectManager(int id, Employee emp)
        //{
        //    Manager.ManagerEmpList.Add(Manager.GetManagerById(id), new List<Employee>() { emp });   
        //}

        Employee emp = new Employee();

        

        public static List<Employee> GetEmployeeOfManager(int id)
        {
            foreach(var manager in Manager.ManagerEmpList)
            {
                if (manager.Key.ID == id)
                    return manager.Value;
            }
            return null ;
        }
    }
}
