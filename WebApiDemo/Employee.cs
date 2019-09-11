using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo
{
    public class Employee //: IEmployee
    {
        public string EmpPost;
        public string Name;
        public int ID;
        public int Salary;
        public int Age;
        public Employee()
        {

        }
        public Employee(string name, int id, int salary, int age, string post)
        {
            Name = name;
            ID = id;
            Salary = salary;
            Age = age;
            EmpPost = post;

        }

        public static List<Employee> EmployeesList = new List<Employee>();


        public static void PutEmployee(Employee emp)
        {

            if (!Employee.EmployeeAlreadyExist(emp))
                 EmployeesList.Add(emp);
            else
                throw new InvalidOperationException("this employee already exists");

        }

        public static bool EmployeeAlreadyExist(Employee emp)
        {
            foreach(Employee empList in EmployeesList)
            {
                if (emp.ID == empList.ID)
                    return true;
            }
            return false;
        }
        
    }
}
