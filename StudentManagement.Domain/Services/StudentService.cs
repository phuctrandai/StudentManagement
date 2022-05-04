using StudentManagement.Core.Context;
using StudentManagement.Core.Models;
using StudentManagement.Domain.Interfaces;

namespace StudentManagement.Domain.Services
{
    public class StudentService : IStudentService
    {
        protected readonly StudentManagementContext _dbContext;

        public StudentService(StudentManagementContext context)
        {
            _dbContext = context;
        }

        public void Create(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges(true);
        }
    }
}
