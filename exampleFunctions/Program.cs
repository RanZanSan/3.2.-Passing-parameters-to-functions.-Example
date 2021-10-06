using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleFunctions
{
    class Program
    {
        static void Print(int[] values)
        {
            int length = values.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write(values[i] + " ");
            }
        }

        static void Change(int[] array)
        {
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                array[i] = array[i] * 2;
            }
        }

        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 4, 5, 7 };
            Print(a);
            Change(a);
            Print(a);
            Console.WriteLine("Конец Main...");
        }
    }
}