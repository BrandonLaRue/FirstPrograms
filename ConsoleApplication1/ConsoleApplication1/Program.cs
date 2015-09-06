using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Loading supervirus...");
            for (int x = 0; x < 500; x++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine("Press g, a, c, q, m, l, or q");
            Console.ReadLine();

            Form1 f = new Form1();
            f.Show();
            f.Activate();


        }
    }
}
