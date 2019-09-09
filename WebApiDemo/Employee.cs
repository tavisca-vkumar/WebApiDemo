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
        //public static List<Employee> ManagerList = new List<Employee>()
        //{
        //    new Employee("vikesh", 1, 5000, 23, "manager"),
        //    new Employee("pandey", 2, 500, 23, "manager")
        //};
        public static List<Employee> EmployeesList = new List<Employee>()
        //{
        //    new Employee("vikesh", 1, 5000, 23, "manager"),
        //    new Employee("pandey", 2, 500, 23, "manager"),
        //    new Employee("ram", 3, 5000, 23, "employee"),
        //    new Employee("shyam", 4, 500, 23, "employee")
        //}
        ;
        public bool EmployeeAlreadyExist(Employee emp)
        {
            foreach(Employee empList in EmployeesList)
            {
                if (emp.ID == empList.ID)
                    return true;
            }
            return false;
        }
        public void PutEmployee(Employee emp)
        {
            
                if (!EmployeeAlreadyExist(emp))
                    EmployeesList.Add(emp);
                else
                    throw new InvalidOperationException("this employee already exists");

        }

        
        //public void PutManagar()
        //{
        //    ManagerList.Add(this);
        //}
        //public void Post(string post)
        //{
        //    EmpPost = post;
        //    if(EmpPost == "Manager")
        //    {
        //        ManagerList.Add()
        //    }
        //}

    }
}
