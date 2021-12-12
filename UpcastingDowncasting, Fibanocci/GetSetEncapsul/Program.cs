using GetSetEncapsul.Model;
using System;

namespace GetSetEncapsul
{
    class Program
    {
        static public void Main()
        {
            Encapsul obj = new Encapsul();
 
            obj.Age = 23;

            Console.WriteLine("I am " + obj.Age + "th year old");
        }
    }
}
