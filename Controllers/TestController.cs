using BookStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {





        [HttpGet]
        public string GetAllEmployees()
        {
            return "All Employees";
        }

        [HttpGet]
        public EmployeeModel GetAllEmployeeModel()
        {
            return new EmployeeModel() {Id = 1,EmployeeName = "Tholkapiyan"};
        }

        [HttpGet]
        public List<EmployeeModel> GetListOfEmployeeModel() 
        {
            return new List<EmployeeModel>()
            {
                new EmployeeModel() { Id = 1, EmployeeName = "Sudhakar"},
                new EmployeeModel() { Id = 2,EmployeeName = "Gobi"},
                new EmployeeModel() { Id = 3,EmployeeName = "Dravid"}
            };
        }


        [HttpGet]
        public IActionResult GetIActionOfEmployeeModel(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var employeeModel = new List<EmployeeModel>()
            {
                new EmployeeModel() { Id = 1, EmployeeName = "Sudhakar"},
                new EmployeeModel() { Id = 2,EmployeeName = "Gobi"},
                new EmployeeModel() { Id = 3,EmployeeName = "Dravid"}
            };
            return Ok(employeeModel);
        }
    }
}
