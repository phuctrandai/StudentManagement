using StudentManagement.Business.Interfaces;
using StudentManagement.Domain.Interfaces;
using System;

namespace StudentManagement.Business.BusinessServices
{
    public class StudentBusiness : IStudentBusiness
    {
        protected IStudentRepository _studentRepository;

        public StudentBusiness(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Test()
        {
            _studentRepository.Create(new Domain.Entities.Student()
            {
                Id = 0,
                Address = "Hue",
                Birthday = DateTime.Now,
                Name = "Phuc"
            });
        }
    }
}
