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
            Class1 cs = new Class1();
            bool on = true;
            string name = "";
            string number = "";

            while (on == true)
            {
                Console.WriteLine("Would you like to get all, add new, or quit?: \n");
                string choise1 = Console.ReadLine();

                switch (choise1)
                { 
                    case "get all":                       
                        cs.GetAll();
                        break;               

                    case "get names":
                        cs.GetNames();
                        break;

                    case "add new":
                        Console.WriteLine("What is the name?\n");
                        name = Console.ReadLine();
                        cs.AddName(name);
                        Console.WriteLine("What is the number?\n");
                        number = Console.ReadLine();
                        cs.AddNumber(number);
                        break;                 

                    case "quit":
                        on = false;
                        break;

                    default:
                        Console.WriteLine("That is not a valid choise\n");
                        break;
                }              
            }
        }
    }
}
