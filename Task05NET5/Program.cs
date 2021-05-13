using System;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task05NET5
{

    class Program
    {
        
        static BindingList<ToDo> toDoList = new BindingList<ToDo>();


        static async Task Main(string[] args)
        {

            Console.WriteLine("**************************************");
            Console.WriteLine("Загрузка данных из файла 'tasks.json': ");


            // сохранение данных
            using (FileStream fs = new FileStream("tasks.json", FileMode.OpenOrCreate))
            {
                ToDo toDo = new ToDo();
                await JsonSerializer.SerializeAsync<ToDo>(fs, toDo);
                Console.WriteLine("Сохранение данных");
            }

            // чтение данных
            using (FileStream fs = new FileStream("tasks.json", FileMode.OpenOrCreate))
            {
                ToDo toDoRead = await JsonSerializer.DeserializeAsync<ToDo>(fs);
                Console.WriteLine($"IsDone: {toDoRead.IsDone}  Title: {toDoRead.Title}");
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

                toDoList.Add(new ToDo() { Title = titleAdd, IsDone = doneAdd });

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


                Console.WriteLine("| " + id + "    " + i.IsDone + "       " + i.Title);
                id++;
            }

            // чтение данных
            using (FileStream fs = new FileStream("tasks.json", FileMode.OpenOrCreate))
            {
                ToDo toDoRead = await JsonSerializer.DeserializeAsync<ToDo>(fs);
                Console.WriteLine($"IsDone: {toDoRead.IsDone}  Title: {toDoRead.Title}");
            }






        }
    }
}
