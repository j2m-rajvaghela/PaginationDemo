using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaginationDemo.API.Data;
using PaginationDemo.API.Model;

namespace PaginationDemo.API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeController(EmployeeContext employeeContext) 
        {
            _employeeContext = employeeContext;
        }

        #region Pagination

        [HttpGet("{page}")]
        public async Task<ActionResult<List<Employee>>> GetEmployees(int page)
        {
            if (_employeeContext.Employees == null)
            {
                return NotFound();
            }

            var pageResults = 5f;

            var pageCount = Math.Ceiling(_employeeContext.Employees.Count()/ pageResults);

            var employees = await _employeeContext.Employees
                            .Skip((page - 1) * (int)pageResults)
                            .Take((int)pageResults)
                            .ToListAsync();

            var response = new EmployeeResponse
            {
                Employees = employees,
                CurrentPage = page,
                Pages = (int)pageCount
            };

            return Ok(response);
        }
        #endregion
    }
}
