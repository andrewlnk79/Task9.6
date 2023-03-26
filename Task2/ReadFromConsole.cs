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
        public static void ReadConsole()
        {
            Console.WriteLine("ввевдите номер сортировки");
            Console.WriteLine(" 1.- по алфовиту");
            Console.WriteLine("2.- в обратном порядке");
            try
            {
                while (true)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number != 1 && number != 2) 
                    {
                        throw new MyExeption("необходимо выбрать 1 или 2");
                    }
                    PushNumber(int number);


                }

            }
            catch (Exception)
            {
                Console.WriteLine(new MyExeption("необходимо выбрать 1 или 2"));
            }
        }
        public virtual void ReadConsole(int number)
        {
            PushNumberHeadler.Invoke(number);
        }
        public delegate void PushNumber(int number);
        public event PushNumber PushNumberHeadler;
    }
}
