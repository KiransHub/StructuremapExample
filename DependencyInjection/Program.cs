using DependencyInjection.ExampleClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = IoC.Container.GetInstance<IStudent>();

            Console.WriteLine(student.Service.GetClassName());
            Console.ReadLine();
        }
    }
}
