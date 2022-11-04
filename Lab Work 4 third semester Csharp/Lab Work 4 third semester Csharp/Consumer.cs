using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work_4_third_semester_Csharp
{
    public class Consumer
    {
        //private Stack<T> name;

        
        private string name;
        
        public Consumer(string name)
        {
            this.name = name;
        }
        

        public void NewStackIsHere(object sender, StackInfoEventArgs e)
        {
            Console.WriteLine("{0}: stack {1} is new", name, e.Stackk);
        }
    }
}
