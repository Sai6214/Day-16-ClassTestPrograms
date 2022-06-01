using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTestProblems
{
    internal class ReverseNumber
    {
        public ReverseNumber()
        {
            int num;
            int rem = 0;
            int reverse = 0;
            Console.WriteLine("Program For Reverse Number \n");
            Console.Write("Enter the Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            Console.WriteLine("Reversed Number : " + reverse);
            Console.WriteLine("--------------------------------------------------------\n\n");
        }
    }
}
