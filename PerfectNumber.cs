using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTestProblems
{
    internal class PerfectNumber
    {
        public PerfectNumber()
        {
            int num;
            int sum = 0;
            Console.WriteLine("Check the Number is Perfect or Not ::\n");
            Console.Write("Enter the number = ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(num + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine(num + " is not a Perfect Number");
            }
            Console.WriteLine("--------------------------------------------------------\n\n");
        }
    }
}
