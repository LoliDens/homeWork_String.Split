using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_String.Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "Данные были успешно удалены";
            string[] lines = line.Split(' ');

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }

            Console.ReadKey();
        }
    }
}
