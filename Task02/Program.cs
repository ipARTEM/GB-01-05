using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dateTime = DateTime.Now;

            string str = dateTime.ToString("HH:mm:ss");
            string filename = "startup.txt";
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllText(filename, str);

            Console.WriteLine($"В фаил 'startup.txt' дописана строка с текущим временем: {dateTime.ToString("HH:mm:ss")} ");


        }
    }
}
