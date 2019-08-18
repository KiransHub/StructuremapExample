using DependencyInjection.ExampleClasses;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public static class IoC
    {
        public static Container Container { get; }
        static IoC()
        {
            Container = new Container(_ =>
            {
                _.For<IStudent>().Use<Student>();
                _.For<IStudentService>().Use<StudentService>();
            });
        }


    }
}
