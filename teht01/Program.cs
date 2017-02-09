using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a few Person objects
            Person person1 = new Person
            {
                Firstname = "Kirsi", Lastname="Mainio", SocialSecurityNumber = "051060-0000"
            };

            Person person2 = new Person
            {
                Firstname = "Mirtsu",
                Lastname = "Hopo",
                SocialSecurityNumber = "021030-0001"
            };
            Person person3 = new Person
            {
                Firstname = "Fernando",
                Lastname = "Torres",
                SocialSecurityNumber = "053020-0350"
            };

            // create a Persons object
            Persons imaginaryfriends = new Persons();

            //add person objects to persons collection
            imaginaryfriends.AddPerson(person1);
            imaginaryfriends.AddPerson(person2);
            imaginaryfriends.AddPerson(person3);

            // get one person from Persons collection
            Person person4 = imaginaryfriends.GetPerson(2);
            if(person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Person not found in that index!");
            }

            // print collection
            imaginaryfriends.PrintCollection();

            //find person
            string sotu = "053020-0350";
            Console.WriteLine("Find sotu: " + sotu);
            Person person5 = imaginaryfriends.FindPerson(sotu);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }else
            {
                Console.WriteLine("Cant find person with that sotu..");
            }
        }
    }
}
