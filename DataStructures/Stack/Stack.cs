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
            this.StackArray = new string[MaxSize];
            // -1 means the array is 0 index, otherwise it will skip first element
            this.Top = -1;
        }


        // TODO: Add error handling
        public void Push(string item)
        {
            Top++;
            StackArray[Top] = item;
        }

        public string Pop()
        {
            int oldTop = Top;
            Top--;
            return StackArray[oldTop];
        }

        public string Peek()
        {
            return StackArray[Top];
        }

        public bool isEmpty()
        {
            return Top == 0;
        }

        public bool isFull()
        {
            return (MaxSize - 1 == Top);
        }

    }
}
