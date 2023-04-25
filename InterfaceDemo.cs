using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public interface InterfaceDemo1
    {
        void Test();
    }

    public interface InterfaceDemo2
    {
        void Test();
    }


    public class Employee : InterfaceDemo1, InterfaceDemo2
    {
        void InterfaceDemo1.Test()
        {
            Console.WriteLine("InterfaceDemo1 Inside Employee class test method");
        }

        void InterfaceDemo2.Test()
        {
            Console.WriteLine("InterfaceDemo2 Inside Employee class test method");
        }

    }
}
