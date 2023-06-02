using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class Stack
    {
        public int MaxSize { get; set; }
        public string[] StackArray { get; set; }
        public int Top { get; set; }

        public Stack(int size)
        {
            this.MaxSize = size;
        }


    }
}
