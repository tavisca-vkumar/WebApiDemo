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
    public class InsertController : ControllerBase
    {
        ManagerEmpController managerEmpController = new ManagerEmpController();

        [HttpPost]
        public void InsertEmployee([FromBody] Employee emp)
        {
            Employee.PutEmployee(emp);
        }

        [HttpPost("{id}")]
        public void Put(int id, [FromBody] Employee emp)
        {
            ManagerEmpController.SelectManager(id, emp);
        }

    }
}