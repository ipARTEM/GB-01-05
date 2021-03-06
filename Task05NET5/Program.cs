using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task05NET5
{

    class Program
    {
        
         


        static async Task Main(string[] args)
        {
            
            List<ToDo> toDoList = new List<ToDo>();

            DataContractJsonSerializer jsonTasks = new DataContractJsonSerializer(typeof(List<ToDo>));

            int id = 1;
            
            if (!File.Exists("tasks.json"))
            {
                using (FileStream fsL = new FileStream("tasks.json", FileMode.OpenOrCreate))
                {
                    jsonTasks.WriteObject(fsL, toDoList);

                }

                Console.WriteLine("Файл'tasks.json' был создан! ");

            }
            else
            {
                Console.WriteLine("Загрузка данных из файла 'tasks.json': ");
                Console.WriteLine("***************************************");
            }


            using (FileStream fsL = new FileStream("tasks.json", FileMode.OpenOrCreate))
            {
                Console.WriteLine("| №  |Сделано|          Задача ");
                //чтение данных
                toDoList = (List<ToDo>)jsonTasks.ReadObject(fsL);
                foreach (var i in toDoList)
                {
                    i.Id = id++;

                    Console.WriteLine("| " + i.Id++ + "    " + i.IsDone + "       " + i.Title);
                    
                }
            }

            while (true)
            {
                
                Console.WriteLine("Введите данные по задаче: ");

                Console.WriteLine("Задача:");

                
                string titleAdd = Console.ReadLine();

                Console.WriteLine("Состояние задачи: нажмите '+'-задача выполнена или любой другой символ задача  не выполнена");

                string doneAdd = Console.ReadLine();

                if (doneAdd == "+")
                {
                    doneAdd = "X";
                }
                else doneAdd = " ";
                //int id=toDoList
                toDoList.Add(new ToDo() { Id = 1,  Title = titleAdd, IsDone = doneAdd }) ;

                Console.WriteLine("Вписать ещё одну задачу или нажмите '-', чтобы показать все задачи");

                string task = Console.ReadLine();

                if (task == "-")
                {
                    break;
                }
                else continue;
            }
            Table:
            Console.WriteLine("| №  |Сделано|          Задача ");
            int idNew = 1;
            foreach (var i in toDoList)
            {
                
                i.Id = idNew++;
                Console.WriteLine("| " + i.Id + "    " + i.IsDone + "       " + i.Title);
            }

            using (FileStream fsL = new FileStream("tasks.json", FileMode.OpenOrCreate))
            {
                //сохранение данных
                jsonTasks.WriteObject(fsL, toDoList);

            }

            do
            {
                Console.WriteLine("Если Вы хотите выйти, нажмите 'пробел' и 'Ввод'  или число с номером задачи, чтобы отметить её как сделанную/не сделанную: ");

                string line= Console.ReadLine();
                int lineInt;

                if (line == " ")
                {
                    break;
                }

                try
                {
                    lineInt = Convert.ToInt32(line);
                    if(0<lineInt && lineInt <= (toDoList.Count+1))
                    {
                        foreach (var i in toDoList)
                        {
                            if (i.Id== lineInt)
                            {
                                if (i.IsDone == "X") i.IsDone = " ";
                                else i.IsDone = "X";
                                goto Table;
                            }
                        }
                    }

                }
                catch (Exception)
                {

                   
                }

           



            } while (true);

            

        }
        
    }
}
