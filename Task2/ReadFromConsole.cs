using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    internal class ReadFromConsole
    {
        internal void ReadConsoleNum()
        {
            Console.WriteLine("ввевдите номер сортировки");
            Console.WriteLine(" 1.- по алфовиту");
            Console.WriteLine("2.- в обратном порядке");



            int number = int.Parse(Console.ReadLine());
            if (number != 1 && number != 2)
                throw new MyExeption("необходимо выбрать 1 или 2");

            ReadConsole(number);



        }
        protected virtual void ReadConsole(int number)
        {
            PushNumberHandler?.Invoke(number);
        }
        public delegate void PushNumber(int number);
        public event PushNumber PushNumberHandler;


    }

}


