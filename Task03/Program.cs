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
            int text=0;


            do
            {
                Console.WriteLine("Введите с клавиатуры произвольное число (0...255), данное число будет записано в бинарный файл: ");

                if (byte.TryParse(Console.ReadLine(), out var inputByte))
                {
                    Console.WriteLine("Ввод соответствует байту, и помещен в переменную inputByte!");
                    Console.WriteLine(inputByte);
                    break;

                }
                else
                {
                    Console.WriteLine("Некоректный ввод!");
                }
            } while (true);

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("bin.bin", FileMode.OpenOrCreate))
            {
                // сириализация 
                formatter.Serialize(fs, text);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация
            using (FileStream fs = new FileStream("bin.bin", FileMode.Open))
            {
                int newText = (int)formatter.Deserialize(fs);

                
                    Console.WriteLine($"десериализация: {newText} ");
                
            }


        }
    }
}
