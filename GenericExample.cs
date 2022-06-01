using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTestProblems
{
    internal class GenericExample
    {
        public void getGen<T>(T[]inputArray)
        {
            Console.WriteLine("Welcome to the generic program\n");
            foreach(T item in inputArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------------------------\n\n");
        }
    }
}
