using System;
using System.Collections.Generic;
using System.Linq;
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
            



        }














        public List<string> CrateList()
        {
            List<string> list = new List<string>();
            list.Add("Петров");
            list.Add("Сидоров");
            list.Add("Иванов");
            list.Add("Васечкин");
            list.Add("Алабаев");
            return list;
        }

        public static void SortA_Z(List<string> list)
        {
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            foreach (var item in list)
            {
                list.Sort();
                Console.WriteLine(item);
            }
        }
        public static void SortZ_A(List<string> list)
        {
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void ReadFromConsole()
        {

            Console.WriteLine("ввевдите номер сортировки");
            Console.WriteLine(" 1.- по алфовиту");
            Console.WriteLine("2.- в обратном порядке");
            try
            {
                var read = int.Parse(Console.ReadLine());
                if (read == 1)
                {


                }

            }
            catch (Exception)
            {
                throw new MyExeption("вы неправильно ввели запрос");
            }

        }
        public  delegate void A_ZHeadler(List<string> list);
        A_ZHeadler sort1 = SortA_Z;

        A_ZHeadler sort2 = new A_ZHeadler(SortZ_A);



    }
}




