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
            /*
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(new FileStream("s1.bin", FileMode.OpenOrCreate), str);     //сириализация в бинарный формат

            BinaryFormatter deBinaty = new BinaryFormatter();
            string newStr = (string)binary.Deserialize(new FileStream("s1.bin", FileMode.Open));  //дисириализация 

            Console.WriteLine(newStr);
            */
            int text=0;
            do
            {
                
                Console.WriteLine("Введите с клавиатуры произвольное число (0...255), данное число будет записано в бинарный файл: ");
                try
                {
                    text =Convert.ToInt32(Console.ReadLine());

                    if (0 <= text && text <= 255)
                    {
                        break;

                    }
                }
                catch (Exception)
                {
                    
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
