using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Surnames
    {
        public static List<string> CrateList()
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
        public static Action<List<string>> sort1 = SortA_Z;
        public static Action<List<string>> sort2 = SortZ_A;

    }
}
