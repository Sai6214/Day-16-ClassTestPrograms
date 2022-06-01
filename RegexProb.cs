using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExamTestProblems
{
    internal class RegexProb
    {
        public RegexProb()
        {
            Console.WriteLine("Check Mobile Your Number is Valid or Not By Using REGEX \n");
            Console.WriteLine("Enter the Correct Mobile Number :: ");
            string mobile = Console.ReadLine();
            string mo = "^[6-9][0-9]{9}$";
            if (Regex.IsMatch(mobile, mo))
            {
                Console.WriteLine("Your Mobile Number is : " + mobile);
            }
            else
            {
                Console.WriteLine("Incorrect Mobile Number : " + mobile);
            }
            Console.WriteLine("------------------------------------------------------------------------\n\n");

            Console.WriteLine("CheckEmail ID By Using REGEX \n\n");
            Console.WriteLine("Enter Your EmailID :: ");
            string email = Console.ReadLine();
            string id = "^[A-Z _ a-z 0-9]+[@]?[a-z]+[/.]?[a-z]{2,3}$";
            if (Regex.IsMatch(email, id))
            {
                Console.WriteLine("Your Email ID is : " + email);
            }
            else
            {
                Console.WriteLine("Incorrect Email ID : " + email);
            }
            Console.WriteLine("------------------------------------------------------------------------\n\n");
        }
    }
}
