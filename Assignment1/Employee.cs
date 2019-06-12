using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Employee
    {
        public Employee( int id,string name,string departmentName)
        {
            this.Id = id;
            Name = name;
            DepartmentName = departmentName;
        }
        
        private int Id;
        private string Name;
        private string DepartmentName;

        public delegate void Event(string s);

        public event Event Event1 = EventFunction;

        //  Event Event1 = new Event(EventFunction);

        public int GetId()
        {
            EventFunction("GetId()");
            return Id;

        }
        public string GetName()
        {
            EventFunction("GetName()");
            return Name;
        }
        public string GetDepartmentName()
        {
            EventFunction("GetDepartmentName()");
            return DepartmentName;
        }

       static public void EventFunction(string s)
        {
            
            Console.WriteLine($" {s} method called");
        }

        public void overloaded_method(int i)

        {

            Id = i;

        }

        public void overloaded_method(string i)

        {

            Name =i;

        }

        public void overloaded_method(int i, string s)

        {

            Id = i;

            DepartmentName = s;

        }
    }
}
