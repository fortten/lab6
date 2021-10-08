using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Удалить из строки текст, заключенный в фигурные скобки. Фрагментов может быть несколько, возможны вложенные фигурные скобки.
            Console.WriteLine("Введите предложение без знаков препинания");
            string s = Console.ReadLine();          
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{')
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] == '}')
                        {
                            s = s.Substring(0, i) + s.Substring(j + 1);
                            break;
                        }
                    }
                }
            }              
            Console.WriteLine(s);
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
