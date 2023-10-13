using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMPHF0002_JQ8Z8Z
{
    internal class PMPHF0002_JQ8Z8Z
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string C = Console.ReadLine();
            Console.Clear();
            for(int i = 0; i < N; i++)
            {
                Console.Write(C);
            }
            Console.WriteLine();
            for (int i = 0; i < N - 2; i++)
            {
                Console.Write(C);
                for(int j = 0; j < N - 2;j++)
                {
                    Console.Write(" ");
                }
                Console.Write(C);
                Console.WriteLine();
            }
            if ( N > 1)
            {
                for (int i = 0; i < N; i++)
                {
                    Console.Write(C);
                }
            }
            Console.ReadLine();
        }
    }
}
