using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    public class Stack
    {
        string[] Buffer;
        int top;

        //top = -1  là normal
        public Stack(int size)
        {
            Buffer = new string[size];
            top = -1;
        }

        public void Push(String value)
        {
            Buffer[top + 1] = value;
            top = top + 1;
        }

        public string Pop()
        {
            String value = Buffer[top];
            top = top - 1;
            return value;
        }

        public string Peek()
        {
            return Buffer[top];
        }
        public int Count()
        {
            return top + 1;

        }
        public void Clear()
        {
            top = -1;
        }
        
    }

}
