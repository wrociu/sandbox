using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveObsoleteSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delim = { ' ' };
            string strOriginal = "Jestem    jaki   jestem i inny   nie bede.       ";
            
            string strOutput = string.Join(" ", strOriginal.Split(delim, StringSplitOptions.RemoveEmptyEntries));

            Console.WriteLine(strOriginal);
            Console.WriteLine(strOutput);
            Console.ReadKey();
        }
    }
}
