using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    public  class ToDo
    {
         int Id=0;

        public string Title { get; set; }

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

