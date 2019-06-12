using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id;
            string Name;
            string DepartmentName;

        Console.WriteLine("enter id");
            Id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name");
            Name=Console.ReadLine();

            Console.WriteLine("Enter department name");
            DepartmentName= Console.ReadLine();

            Employee emp = new Employee(Id, Name, DepartmentName);
            Console.WriteLine(emp.GetId());
            Console.WriteLine(emp.GetName());
            Console.WriteLine(emp.GetDepartmentName());
            Console.ReadLine();
            emp.overloaded_method(5);
        }
    }
}
