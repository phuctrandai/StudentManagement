using StudentManagement.Business.Interfaces;
using StudentManagement.Core.Models;
using StudentManagement.Domain.Interfaces;
using System;

namespace StudentManagement.Business.BusinessServices
{
    public class StudentBusiness : IStudentBusiness
    {
        protected IStudentService _studentService;

        public StudentBusiness(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void Test()
        {
            _studentService.Create(new Student()
            {
                Id = 0,
                Address = "Hue",
                Birthday = DateTime.Now,
                Name = "Phuc"
            });
        }
    }
}
