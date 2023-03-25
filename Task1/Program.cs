using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program: MyExeption  
    {
        public Program(string message) : base(message)
        {
        }

        static void Main(string[] args)
        {
            ArrayList exeptions = new ArrayList();
            exeptions.Add(new MyExeption("My exeption"));
            exeptions.Add(new OutOfMemoryException());
            exeptions.Add(new StackOverflowException());
            exeptions.Add(new IndexOutOfRangeException());
            exeptions.Add(new ArithmeticException());
            int num1, num2;
            num1 = new Random().Next(1, 100);
            num2 = 0;

            try
            {
                var res = num1 / num2;
            }
            catch (Exception)
            {

                MyExeption.Enumeration(exeptions);
            }
            Console.ReadKey();
        }
    }
}
