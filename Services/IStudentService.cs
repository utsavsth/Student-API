using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Services
{
  public interface IStudentService
  {
    IQueryable<Student> RetrieveAllStudents();

  }
}
