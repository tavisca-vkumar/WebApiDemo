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
    public class ManagerController : ControllerBase
    {
        Employee Emp = new Employee();
        // GET api/manager
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllManagers()
        {
            return Manager.GetManagerList() ;
        }


        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Employee>> GetEmployeesByManagerID(int id)
        {
            return ManagerEmpController.GetEmployeeOfManager(id);
        }

    }
}