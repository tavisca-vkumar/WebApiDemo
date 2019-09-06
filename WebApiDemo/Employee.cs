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
        public static List<Employee> ManagerList = new List<Employee>()
        {
            new Employee("vikesh", 1, 5000, 23, "manager"),
            new Employee("pandey", 2, 500, 23, "manager")
        };
        public static List<Employee> EmployeesList = new List<Employee>()
        {
            new Employee("vikesh", 1, 5000, 23, "manager"),
            new Employee("pandey", 2, 500, 23, "manager"),
            new Employee("ram", 3, 5000, 23, "employee"),
            new Employee("shyam", 4, 500, 23, "employee")
        };

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
