using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.ExampleClasses
{
    class Student: IStudent
    {
        public IStudentService Service { get; }

        public Student(IStudentService studentService)
        {
            Service = studentService;
        }

    }
}
