using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    abstract public class Person1
    {
        abstract public void Test();
    }

    abstract public class Person2
    {
        abstract public void Test();
    }


    public class Student :Person1
    {
        public override void Test()
        {
            Console.WriteLine("Inside Student class Test method");
        }
    }
}
