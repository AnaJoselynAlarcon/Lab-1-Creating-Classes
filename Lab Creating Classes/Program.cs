using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Creating_Classes
{
    /// <summary>
    /// Represents a list of people
    /// </summary>
    /// <remarks>Author: Ana Alarcon </remarks>
    /// <remarks>Date: January 19, 2023</remarks>

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1;
            person1 = new Person(1, "Ian", "Brooks", 30, "Red", true);

            Person person2;
            person2 = new Person(2, "Gina", "James", 18, "Green", false);

            Person person3;
            person3 = new Person(3, "Mike", "Briscoe", 45, "Blue", true);

            Person person4;
            person4 = new Person(4, "Mary", "Beals", 28, "Yellow", true);

            
            
            
            
            person2.DisplayPersonInfo();

            Console.WriteLine(person3.ToString());

            Console.WriteLine($"Mary Beal's Age in 10 years is: {person4.GetAgeInTenYears()}");

            person1.ChangeFavoriteColor("White");
            person1.DisplayPersonInfo();
            
            
            
            
            
            
            
            
            
            
            //person1.favoriteColor = "White";

            //string favColor = person1.ChangeFavoriteColour;
            //Console.WriteLine(favColor);

        }
    }
}
