using System;
using System.Collections.Generic;
using Xunit;

namespace WebApiDemo.Tests
{
    public class EmployeeTests
    {
       
        [Fact]
        public void test_Employee_Added()
        {
            Employee emp = new Employee();
            var EmpPandey = new Employee("pandey", 2, 500, 23, "manager");
            var EmpVikesh = new Employee("vikesh", 1, 5000, 23, "manager");
            emp.PutEmployee(EmpVikesh);
            emp.PutEmployee(EmpPandey);
            foreach (Employee employee in Employee.EmployeesList)
            {
                if (employee == EmpVikesh)
                {
                    Assert.Equal(EmpVikesh, employee);
                }
            }
            //Assert.Equal(EmpVikesh, Employee.EmployeesList[0]);
        }
        [Fact]
        public void test_Check_Duplicacy()
        {
            Employee emp = new Employee();
            var EmpVikesh1 = new Employee("vikesh", 3, 5000, 23, "manager");
            var EmpPandey1 = new Employee("pandey", 3, 500, 23, "manager");
            emp.PutEmployee(EmpVikesh1);
            var ex = Assert.Throws<InvalidOperationException>(() => emp.PutEmployee(EmpPandey1));
            Assert.Equal("this employee already exists", ex.Message);
            
        }
        [Fact]
        public void Test_IsValidManager()
        {
            Employee emp = new Employee();
            var InvalidManager = new Employee("Aniket", 6, 5000, 23, "employee");
            var ValidManager = new Employee("Vikesh Singh", 7, 500000, 23, "manager");
            Assert.Equal(1 == 2, ManagerEmpController.IsValidManager(InvalidManager));
            Assert.Equal(1 == 1, ManagerEmpController.IsValidManager(ValidManager));
        }
        [Fact]
        public void Test_SelectManager()
        {
            Employee emp = new Employee();
            var empA = new Employee("empA", 8, 5000, 23, "employee");
            var empB = new Employee("empB", 9, 5000, 23, "employee");
            var empC = new Employee("empC", 10, 5000, 23, "employee");
            var managerA = new Employee("managerA", 11, 60000, 23, "manager");
            var empUnderAManagerList = new List<Employee>();
            empUnderAManagerList.Add(empA);
            empUnderAManagerList.Add(empB);
            empUnderAManagerList.Add(empC);
            ManagerEmpController.SelectManager(managerA, empA);
            ManagerEmpController.SelectManager(managerA, empB);
            ManagerEmpController.SelectManager(managerA, empC);
            Assert.Equal(empUnderAManagerList, Manager.ManagerEmpList[managerA]);
        }
    }
}
