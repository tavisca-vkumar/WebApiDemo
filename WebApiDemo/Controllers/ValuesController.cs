using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //Employee employee = new Employee();
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Employee.EmployeesList;
        }

        public List<Employee> EmployeesOfManager = new List<Employee>();

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Employee> GetMangerByID(int id)
        {
            //return "aesrtyt";
            foreach (Employee manager in Employee.EmployeesList)
            {
                if (manager.ID == id)
                    return manager;
            }
            
            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
