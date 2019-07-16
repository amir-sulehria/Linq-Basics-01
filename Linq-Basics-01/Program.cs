using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Basics_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstration of how linq work behind the scenes

            string name = "Will Smith";
            //string modifiedName = StringHelper.ChangeFirstLetterCase(name);
            //below is extension method
            string modifiedName = name.ChangeFirstLetterCase();
            Console.WriteLine(modifiedName);

            List<int> list = new List<int>{1, 2, 3, 5, 6, 7, 8, 9, 10};
            IEnumerable<int> evenNum = list.Where(num => num % 2 == 0);
            //IEnumerable<int> evenNum = Enumerable.Where(list, num => num % 2 == 0);
            foreach (int n in evenNum)
            {
                Console.Write(n + "\t");
            }
        }
    }
}
