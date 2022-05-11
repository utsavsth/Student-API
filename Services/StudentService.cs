using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Services
{
  public class StudentService : IStudentService
  {
    public IQueryable<Student> RetrieveAllStudents()
    {
      return new List<Student>
      {
        new Student
        {
          Id = Guid.NewGuid(),
          Name = "Vishu Goli",
          Score = 200
        },
        new Student
        {
          Id = Guid.NewGuid(),
          Name = "Kailu Hu",
          Score = 150
        },
        new Student
        {
          Id = Guid.NewGuid(),
          Name = "Lee Kong",
          Score = 160
        },
        new Student
        {
          Id = Guid.NewGuid(),
          Name = "Mark Goli",
          Score = 190
        },
      }.AsQueryable();
    }
  }
}
