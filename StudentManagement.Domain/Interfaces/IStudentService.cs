using StudentManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Domain.Interfaces
{
    public interface IStudentService
    {
        void Create(Student student);
    }
}
