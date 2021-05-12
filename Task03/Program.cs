using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Task03
{

    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите с клавиатуры произвольный набор чисел (0...255), данный набор будет записан в бинарный файл: ");

            string str = "000";


            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(new FileStream("s1.bin", FileMode.OpenOrCreate), str);     //сириализация в бинарный формат


            


            //BinaryFormatter deBinaty = new BinaryFormatter();

            string newStr = (string)binary.Deserialize(new FileStream("s1.bin", FileMode.OpenOrCreate));


            Console.WriteLine(newStr);


        }
    }
}
