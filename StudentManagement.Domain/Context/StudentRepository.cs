using StudentManagement.Domain.Interfaces;
using StudentManagement.Domain.Models;

namespace StudentManagement.Domain.Context
{
    public class StudentRepository : IStudentRepository
    {
        protected readonly StudentManagementContext _dbContext;

        public StudentRepository(StudentManagementContext context)
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
