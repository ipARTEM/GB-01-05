using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace SerializationJSONTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Tom", 37);
            Person person2 = new Person("Poo", 23);
            Person[] people = new Person[] { person1, person2 };

            DataContractJsonSerializer jsonF = new DataContractJsonSerializer(typeof(Person[]));

            using (FileStream fs= new FileStream("people.json",FileMode.OpenOrCreate))
            {
                jsonF.WriteObject(fs, people);

            }

            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                Person[] newpeople = (Person[])jsonF.ReadObject(fs);
                foreach (Person p in newpeople)
                {
                    Console.WriteLine($"Имя: {p.Name}, Возраст: {p.Age}");

                }
            }

            List<Person> peopleList = new List<Person>();

            peopleList.Add(new Person() { Name="Bill", Age=35 });
            peopleList.Add(new Person() { Name = "Jack", Age = 35 });
            peopleList.Add(new Person() { Name = "Mickey", Age = 69 });
            peopleList.Add(new Person() { Name = "Steve", Age = 22 });


            foreach (var i in peopleList)
            {
                Console.WriteLine($" {i.Name }, {i.Age } ");

            }
            Console.WriteLine("************************************");
            DataContractJsonSerializer jsonList = new DataContractJsonSerializer(typeof(List<Person>));

            using (FileStream fsL = new FileStream("jsonList.json", FileMode.OpenOrCreate))
            {
                jsonList.WriteObject(fsL, peopleList);

            }

            using (FileStream fsL = new FileStream("jsonList.json", FileMode.OpenOrCreate))
            {
                List<Person> newpeople = (List<Person>)jsonList.ReadObject(fsL);
                foreach (var i in newpeople)
                {
                    Console.WriteLine($" {i.Name }, {i.Age}");

                }
            }


        }
    }
}
