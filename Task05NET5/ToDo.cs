using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task05NET5
{
    [DataContract]
    public class ToDo
    {
        [DataMember]
        public int Id { get; set; } = 1;

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string IsDone { get; set; }
        public ToDo()
        {

        }

        public ToDo(string title, string isDone)
        {
            
            Title = title;
            IsDone = isDone;
        }
    }
}
