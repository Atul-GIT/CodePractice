using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter size of pyramid in odd");
           var size = Console.ReadLine();
            int s = 0;
           if (int.TryParse(size, out s) && (s%2 != 0))
            {
                PrintNumberPyramid(s);
                PrintStarPyramid(s);
                PrintRevPyramid(s);
            }
            Console.ReadLine();
           
        }

        static void PrintNumberPyramid(int size)
        {
            string space = " ";
            string star = "*";
            int height = size / 2 + 1;
            int istPrint = 0;
            for (int i = 0; i < height; i++)
            {
                istPrint = size - 2 * i;
                for (int spPrint = 0; spPrint < i; spPrint++)
                {
                    Console.Write(space);
                }
                for (int stPrint = 1; stPrint <= istPrint; stPrint++)
                {
                    Console.Write(stPrint);
                }
                for (int spPrint = 0; spPrint < i; spPrint++)
                {
                    Console.Write(space);
                }
                Console.WriteLine("");
            }

        }
        static void PrintStarPyramid(int size)
        {
            string space = " ";
            string star = "*";
            int height = size / 2 + 1;
            int istPrint = 0; 
            for (int i = 0; i < height; i++)
            {
                istPrint = size - 2 * i;
                for (int spPrint = 0; spPrint < i; spPrint++)
                {
                    Console.Write(space);
                }
                for (int stPrint = 0; stPrint <istPrint ; stPrint++)
                {
                    Console.Write(star);
                }
                for (int spPrint = 0; spPrint < i; spPrint++)
                {
                    Console.Write(space);
                }
                Console.WriteLine("");
            }

        }
        static void PrintRevPyramid(int size)
        {
            string space = " ";
            string star = "*";
            int height = size / 2 + 1;
            int istPrint = 0;
            for (int i = height-1; i >= 0; i--)
            {
                istPrint = size - 2 * i;
                for (int spPrint = 0; spPrint < i; spPrint++)
                {
                    Console.Write(space);
                }
                for (int stPrint = 0; stPrint < istPrint; stPrint++)
                {
                    Console.Write(star);
                }
                for (int spPrint = 0; spPrint < i; spPrint++)
                {
                    Console.Write(space);
                }
                Console.WriteLine("");
            }

        }
    }
}
