using Hospital_OPD___Appointment_Management_System__HAMS_.Modal.Entities;
using Hospital_OPD___Appointment_Management_System__HAMS_.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_OPD___Appointment_Management_System__HAMS_.Controllers
{
    [ApiController]
    [Route("api[controller]")]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServices _service;

        public DepartmentController(IDepartmentServices service)
        {
            _service = service;
        }

        //(1)Create New Department
        [HttpPost("CreateDepartment")]
        public async Task<IActionResult> CreateDepartment([FromBody]Department department)
        {
            if (string.IsNullOrEmpty(department.Name))
            {
                return BadRequest("Department name is required");
            }
            await _service.CreateDepartment(department);
            return Ok($"depart created with {department.Id} and {department.Name}");
        }

        //(2)Get All Department 
        [HttpGet("GetAllDepartment")]
        public async Task<ActionResult<IEnumerable<Department>>> GetAllDepartment()
        {
            var dept = await _service.GetAllDepartement();
            if(dept == null) { NotFound(); }
            return Ok(dept);
        }

        //(3)Get Dept by Id
        [HttpGet("GetDepartmentById/{id}")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            var dept = await _service.GetDepartmentById(id);
            if (dept == null) { NotFound(); }
            return Ok(dept);
        }

        //(4)Update Department
        [HttpPut("UpdateDepartment/{id}")]
        public async Task<ActionResult> UpdateDepartment(int id, [FromBody] Department department)
        {
            var dept = await _service.GetDepartmentById(id);
            if (dept == null) { return NotFound("Department not found"); }

            if (id != department.Id) { return BadRequest("ID mismatch between route and body."); }

            await _service.UpdateDepartment(id, department);
            return Ok("Department updated successfully");
        }



        //(5)Delete Department
    }
}
