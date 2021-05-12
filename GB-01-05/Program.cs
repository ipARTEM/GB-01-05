using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вставьте с клавиатуры произвольный набор символов и они сохранятся в файле 'text.txt': ");

            string str = Console.ReadLine();
            string filename = "text.txt";
            File.WriteAllText(filename, str); // записываем в файл строку


        }
    }
}
