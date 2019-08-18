using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.ExampleClasses
{
    public class StudentService : IStudentService
    {
        public string GetClassName()
        {
            //... do some sort of service db look up... 
            return "History";
        }
    }
}

