using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод предложения. Слова разделены пробелом, знаки препинания не используются. Найти самое длинное слово.
            Console.WriteLine("Введите предложение без знаков препинания");
            string s = Console.ReadLine();
            string[] array = s.Split(' ');
            int length = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > length)
                {
                    length = array[i].Length;
                    index = i;
                }               
            }            
            Console.WriteLine("Самое длинное слово в предложении - {0}", array[index]);            
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
