using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            return Employee.EmployeesList;
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetManagerByID(int id)
        {
            //return "aesrtyt";
            foreach (Employee manager in Employee.EmployeesList)
            {
                if (manager.ID == id)
                    return manager;
            }

            return NotFound();
        }
    }
}