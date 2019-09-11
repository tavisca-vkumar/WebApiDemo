using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
namespace WebApiDemo.Tests
{
    public class EmployeeTests
    {
        Employee empA = new Employee("empA", 8, 5000, 23, "employee");
        Employee empB = new Employee("empB", 9, 5000, 23, "employee");
        Employee empC = new Employee("empC", 11, 60000, 23, "employee");
        Employee empD = new Employee("empD", 10, 60000, 23, "employee");

        Employee InvalidManager = new Employee("Aniket", 6, 5000, 23, "employee");

        Employee managerA = new Employee("managerA", 12, 60000, 23, "manager");
        Employee managerB = new Employee("managerB", 13, 60000, 23, "manager");
        [Fact]
        public void test_Check_Duplicacy()
        {
            //ManagerEmpController emp = new ManagerEmpController();
            //Employee.PutEmployee(empA);

            var ex = Assert.Throws<InvalidOperationException>(() => Employee.PutEmployee(empA));
            Assert.Equal("this employee already exists", ex.Message);

        }

        [Fact]
        public void test_Employee_Added()
        {
            //ManagerEmpController emp = new ManagerEmpController();

            Employee.PutEmployee(empA);
            Employee.PutEmployee(empB);
            Employee.PutEmployee(empC);
            Employee.PutEmployee(empD);
            Employee.PutEmployee(managerA);
            Employee.PutEmployee(managerB);
            foreach (Employee employee in Employee.EmployeesList)
            {
                if (employee == empA)
                {
                    //empA.Should().BeEquivalentTo(employee);
                    Assert.Equal(empA, employee);
                }
            }
        }
        


        //[Fact]
        //public void Test_IsValidManager()
        //{
        //    ManagerEmpController.SelectManager(managerA.ID, empA);
        //    ManagerEmpController.SelectManager(managerA.ID, empB);

        //    ManagerEmpController.SelectManager(managerB.ID, empC);
        //    ManagerEmpController.SelectManager(managerB.ID, empD);

        //    Assert.Equal(1 == 2, Manager.IsValidManager(InvalidManager.ID));
        //    Assert.Equal(1 == 1, Manager.IsValidManager(managerA.ID));
        //}
        //[Fact]
        //public void Test_SelectManager()
        //{
        // //   Employee emp = new Employee();

        //    var empUnderAManagerAList = new List<Employee>();
        //    empUnderAManagerAList.Add(empA);
        //    empUnderAManagerAList.Add(empB);
        //    empUnderAManagerAList.Add(empC);
        //    ManagerEmpController.SelectManager(managerA.ID, empA);
        //    ManagerEmpController.SelectManager(managerA.ID, empB);
        //    ManagerEmpController.SelectManager(managerA.ID, empC);
        //    ManagerEmpController.SelectManager(managerB.ID, empC);
        //    ManagerEmpController.SelectManager(managerB.ID, empA);
        //    Assert.Equal(empUnderAManagerAList, Manager.ManagerEmpList[managerA]);

        //    var empUnderAManagerBList = new List<Employee>();
        //    empUnderAManagerBList.Add(empC);
        //    empUnderAManagerBList.Add(empA);
        //    Assert.Equal(empUnderAManagerBList, Manager.ManagerEmpList[managerB]);
        //}
        //[Fact]
        //public void Test_GetManagersList()
        //{
        //    List<Employee> managersList = new List<Employee>();
        //    managersList.Add(managerA);
        //    managersList.Add(managerB);
        //    //ManagerEmpController.SelectManager(managerA, empA);
        //    //ManagerEmpController.SelectManager(managerB, empB);
        //    //Assert.Equal(managersList, Manager.GetManagerList());
        //    //Assert.Same(managersList, Manager.GetManagerList());
        //    managersList.Should().BeEquivalentTo(Manager.GetManagerList());
        //}
    }
}
