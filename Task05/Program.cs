using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Task05
{
    class Program
    {
        static ToDo toDo = new ToDo();
        static BindingList<ToDo> toDoList = new BindingList<ToDo>();

        

        static void Main(string[] args)
        {
            Console.WriteLine("Загрузка данных из файла 'tasks.json': ");

            BinaryFormatter formatter = new BinaryFormatter();


            using (FileStream fs = new FileStream("tasks.json", FileMode.OpenOrCreate))
            {
                try
                {
                    if (formatter != null)
                    {
                        var fileText = reader.ReadToEnd();
                        toDoList = JsonConvert.DeserializeObject<BindingList<ToDo>>();

                        Console.WriteLine($"десериализация: {toDoList} ");
                    }
                    else
                    {

                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Данные в файле отсутствуют. ");
                }

            }
         


            Console.WriteLine("**************************************");
            

            while (true)
            {
                Console.WriteLine("Введите данные по задаче: ");

                Console.WriteLine("Задача:");

                string titleAdd = Console.ReadLine();

                Console.WriteLine("Состояние задачи: нажмите '+'-задача выполнена или любой другой символ задача  не выполнена");

                string  doneAdd = Console.ReadLine();

                if (doneAdd == "+")
                {
                    doneAdd = "X";
                }
                else doneAdd = " ";

                toDoList.Add(new ToDo() { Title= titleAdd, IsDone= doneAdd });

                Console.WriteLine("Вписать ещё одну задачу или нажмите '-', чтобы показать все задачи");

                string task = Console.ReadLine();

                if (task == "-")
                {
                    break;
                }
                else continue;
            }

            Console.WriteLine("| №  |Сделано|          Задача ");
            int id = 1;
            foreach (var i in toDoList)
            {
                

                Console.WriteLine("| " + id +"    "+ i.IsDone+"       "+i.Title);
                id++;
            }

            int s = 2;


            


            using (FileStream fs = new FileStream("tasks.json", FileMode.OpenOrCreate))
            {
                string output = JsonSerializer.Serialize<ToDo>(toDoList);

                writer.Write(output);

                Console.WriteLine("Объект сериализован");
            }
        }
    }
}
