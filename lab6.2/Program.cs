using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод предложение. Слова разделены пробелом, знаки препинания не используются. Проверить, явлеяется ли оно палиндромом.
            Console.WriteLine("Введите предложение без знаков препинания");
            string s = Console.ReadLine();
            s = s.Replace(" ", string.Empty);
            s = s.ToLower();
            bool b = true;
            char[] array = s.ToCharArray();
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                {                   
                    b = false;
                    break;
                }
            }            
            Console.WriteLine("Предложение " + ((b) ? "является" : "не является") + " палиндромом");
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }

    }
}