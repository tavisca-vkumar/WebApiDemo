using System;
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
    }
}
