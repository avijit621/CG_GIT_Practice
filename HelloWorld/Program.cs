using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS;
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Today is Tuesday");
            Employee employee = new Employee { ID=20,Name="Tom",Salary=20000};
        }
    }
}
