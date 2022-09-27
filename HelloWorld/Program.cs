using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS;
using Employee;
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Today is Tuesday");
            Class1 employee = new Class1 { ID=20,Name="Tom",Salary=20000};
        }
    }
}
