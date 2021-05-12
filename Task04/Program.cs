using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString();

            string line = Path.GetFullPath("task04.txt");

            string lineSave = date+" "+ line;

            string fileName = "task04.txt";

            string fileString = @"D:\Программирование\GeekBrains\C# Разработчик\GB-01-05\Task04\bin\Debug\task04.txt";

            File.AppendAllText(fileName, Environment.NewLine);
            File.AppendAllText(fileName, lineSave);
            File.AppendAllText(fileName, Environment.NewLine);
            File.AppendAllText(fileString, lineSave);

            Console.WriteLine(lineSave);

        }
    }
}
