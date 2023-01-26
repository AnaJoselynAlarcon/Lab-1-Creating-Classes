using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Creating_Classes
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;



        //----CONSTRUCTOR
        /// <summary>
        /// Initializes a Person object with Id, Name, Last Name, Age, Favorite color and Work Status.
        /// </summary>
        /// <param name="personId">Sets the Id number</param>
        /// <param name="firstName">Sets the person's name</param>
        /// <param name="lastName">Sets the person's  last name</param>
        /// <param name="age">Sets the person's age</param>
        /// <param name="favoriteColor">Sets the person's Favorite color</param>
        /// <param name="isWorking">Sets the person's working status</param>
        public Person(int personId, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.favoriteColor = favoriteColor;
            this.isWorking = isWorking;
        }
        public void DisplayPersonInfo()
        {
            string firstName = this.firstName;
            string lastName = this.lastName;
            string favoriteColor = this.favoriteColor;

            Console.WriteLine(firstName + " " + lastName + "'s favorite color is " + favoriteColor);
        }

        public void ChangeFavoriteColor(string favColor)
        {
            this.favoriteColor = favColor;
        }
        //hardcoded color = 'white';
        public string ChangeFavoriteColour
        {
            get
            {
                return this.favoriteColor;
            }
            set
            {
                if ((favoriteColor == "Red" || favoriteColor == "blue" || favoriteColor == "green") == false)
                {
                    return;
                }
                this.favoriteColor = "white";
            }
        }



        public int GetAgeInTenYears()
        {
            int age10;
            age10 = age + 10;
            return age10;
        }
        //var = is a shortcut for datatypes but is not a good practice.
        public override string ToString()
        {
            return $"PersonId: {personId}\nFirstName: {firstName}\nLastName:{lastName}\nFavoriteColour: {favoriteColor}\nAge: {age}\nIsWorking: {isWorking}";

        }

        //create a class called relation
        //"sisterhood" brotherhood"
        //    public void showrelationship (person1, person2)
        //{ switch(relationshiptipe)
        //        case...}

        //List<Person> people= new List<Person>();
        //people.Add(Ian);
        //people.Add(Gina);
        //people.Add(mike);
        //people.
        
    }
}
