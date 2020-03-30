using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace OOPSConcepts
{
    class ClassRoom
    {
        public void classRoomMethod()
        {
            Console.WriteLine("I am inside the Parent Class");
        }
    }
    class child : ClassRoom
    {
        new public void classRoomMethod()
        {
            Console.WriteLine("I am insie the child class");
        }
    }
    class NewClass
    {
        static void Main(string[] args)
        {
            child objChild = new child();
            objChild.classRoomMethod();
            Console.ReadLine();

        }
    }
}