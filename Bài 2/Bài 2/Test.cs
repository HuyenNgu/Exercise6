using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    class Test
    {
        //gán lại từng thứ tự trong mảng
        public static void Main(string[] args)
        {   
            String[] array = { "Pham", "Ngoc", "Duy" };
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
    }
}
