using StudentManagement.Domain.Interfaces;
using StudentManagement.Domain.Entities;

namespace StudentManagement.Domain.Context
{
    public class StudentRepository : IStudentRepository
    {
        protected readonly StudentManagementDbContext _dbContext;

        public StudentRepository(StudentManagementDbContext context)
        {
            _dbContext = context;
        }

        public void Create(Student student)
        {
            _dbContext.Student.Add(student);
            _dbContext.SaveChanges(true);
        }
    }
}
