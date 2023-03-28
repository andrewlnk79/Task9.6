using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Task1;
//Создайте консольное приложение, в котором будет происходить сортировка списка фамилий из пяти человек.
//Сортировка должна происходить при помощи события. Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А).
//Дополнительно реализуйте проверку введённых данных от пользователя через конструкцию TryCatchFinally с использованием собственного типа исключения.
namespace Task2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var surnames = new Surnames();
            ReadFromConsole read = new ReadFromConsole();
            while (true)
            {

                try
                {


                    read.ReadConsoleNum();






                }
                catch (Exception)
                {

                    Console.WriteLine(new MyExeption("необходимо выбрать 1 или 2"));
                }
                read.PushNumberHandler += (number) =>
                {


                    if (number == 1)
                    {
                        Surnames.SortA_Z(Surnames.CrateList());
                    }
                    else
                    {
                        Surnames.SortZ_A(Surnames.CrateList());
                    }

                };
            }
            Console.ReadKey();




        }



    }
}







