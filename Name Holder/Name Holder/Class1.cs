using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        List<string> names = new List<string>();
        List<string> numbers = new List<string>();

        public void AddName(string name)
        {
            names.Add(name);
        }
        public void AddNumber(string number)
        {
            numbers.Add(number);
        }



      
        public void GetAll()
        {
            for (int count = 0; count < 50; count++)
            {
                try
                {
                    Console.WriteLine(names[count]);
                    Console.WriteLine(numbers[count] + "\n");
                }
                catch
                {
                }
                finally 
                {
                }
            }
        }
        public void GetNames()
        {
            foreach (string var in names)
            {
                Console.WriteLine(var);
            }
        }




        

        

    }
}
