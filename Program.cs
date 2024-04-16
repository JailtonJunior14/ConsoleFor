using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despesas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello, World");   
            //}
            for (int i = 1; i<=9; i++)
            {
                Console.Write(i);

                Console.Write("");

                for (int j = 1; j<=9; j++)
                    
                {
                   if (i != j)
                    {
                        Console.Write(j);
                    }
                        
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}




