using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTestProblems
{
    internal class ListExample
    {
        public void food()
        {
            Console.WriteLine("List Program \n\n");
            List<string> food = new List<string>();
            food.Add("Tea");
            food.Add("Pizza");
            food.Add("Hotdog");
            food.Add("Burger");
            food.Add("Coffee");
            food.Add("Tea");
            //Console.WriteLine(food[4]);                     //printing index value
            //Console.WriteLine(food.Capacity); checkng capacity of array
            //food.Remove("Coffee");                          // Removing the data from array list
            //food.Insert(1, "Milk");                         // inserting the value or data anywhere in the Array list
            //Console.WriteLine(food.Count);                  // Count total element in arraylist
            // Console.WriteLine(food.IndexOf("Hotdog"));      // Perticular index of element
            //Console.WriteLine(food.LastIndexOf("Tea"));7    // check last index of element
            //Console.WriteLine(food.Contains("Coffee"));     // if element PRESENT in a list then its gives 'True' if ABSENT it gives 'False'
            //food.Sort();                                    // for sorting from A to Z or 1 to last element
            //food.Reverse();                                 //for reverse last to first element
            //food.Clear();
            //string[] foodeArray = food.ToArray();

            foreach (string item in food)
            {
                Console.WriteLine(item);
            }
        }
    }
}
