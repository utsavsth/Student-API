using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System.Linq;
using TodoApi.Models;
using TodoApi.Services;

namespace TodoApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StudentsController : ControllerBase
  {
    private readonly IStudentService _studentService;
    public StudentsController(IStudentService studentService) => this._studentService = studentService;

    [HttpGet, EnableQuery]
    public ActionResult<IQueryable<Student>> GetAllStudents(
      [FromQuery(Name = "$top")] int top,
      [FromQuery(Name = "$skip")] int skip,
      [FromQuery(Name = "$orderby")] string orderby,
      [FromQuery(Name = "$filter")] string filter,
      [FromQuery(Name = "$select")] string select
      )
    {
      IQueryable<Student> retrievedStudents = _studentService.RetrieveAllStudents();

      return Ok(retrievedStudents);
    }
  }
}
