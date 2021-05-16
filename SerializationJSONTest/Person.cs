using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationJSONTest
{
    [DataContract]
    class Person
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }

        public Person()
        {
            
        }

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }



    }
}
