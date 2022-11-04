using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work_4_third_semester_Csharp
{
    public class StackInfoEventArgs : EventArgs
    {
        

        public StackInfoEventArgs(string stackk)
        {
            this.Stackk = stackk;
        }

        //public Stack<T> Stackk { get; private set; }
        
        public string Stackk { get; private set; }
    
    }

    public class StackkItems
    {
        public event EventHandler<StackInfoEventArgs> NewStackInfo;

        //public event EventHandler<StackInfoEventArgs> NewStackInfo;

        public void NewStack(string stackk)
        {
            Console.WriteLine("Stack items, new stack{0}", stackk);

            if(NewStackInfo != null)
            {
                NewStackInfo(this, new StackInfoEventArgs(stackk));
            }
        }
    }
}
