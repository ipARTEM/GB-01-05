using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static ToDo toDo = new ToDo();
        static List<ToDo> toDoList = new List<ToDo>();

        

        static void Main(string[] args)
        {
            Console.WriteLine("Загрузка данных из файла 'tasks.json': ");

            if (true)
            {
                Console.WriteLine("Данные в файле отсутствуют. ");

            }

            Console.WriteLine("**************************************");
            //Console.WriteLine("|№   |Сделано|          Задача ");

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

            foreach (var i in toDoList)
            {
                Console.WriteLine(i.IsDone+" "+i.Title);
            }
            toDoList.Add(toDo);
        }

        private static void PrintTask()
        {
            
        }
    }

}
