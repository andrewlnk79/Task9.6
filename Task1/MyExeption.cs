using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте свой тип исключения.
//Сделайте массив из пяти различных видов исключений, включая собственный тип исключения.
//Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).
//В блоке catch выведите в консольном сообщении текст исключения.
namespace Task1
{
    public class MyExeption:Exception
    {
        public MyExeption(string message):base(message)  
        {
            
        }
        public static void Enumeration(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
