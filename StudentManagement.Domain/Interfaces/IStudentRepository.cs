using StudentManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Domain.Interfaces
{
    public interface IStudentRepository
    {
        void Create(Student student);
    }
}
