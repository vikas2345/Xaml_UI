using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamls.Models;

namespace Xamls.Data
{
    public class ContactGenerator
    {
        public static List<string> FirstNames = new List<string>{
            "Aiden", "Liam", "Lucas", "Noah", "Mason", "Ethan", "Caden", "Jacob", "Logan", "Jayden", "Elijah", "Jack", "Luke", "Michael", "Benjamin",
            "Alexander", "James", "Jayce", "Caleb", "Connor", "William", "Carter", "Ryan", "Oliver", "Matthew", "Daniel", "Gabriel", "Henry", "Owen",
            "Grayson", "Lincoln", "Jordan", "Tristan", "Jason", "Josiah", "Xavier", "Camden", "Chase", "Declan", "Carson", "Colin", "Brody", "Asher",
            "Jeremiah", "Micah", "Easton", "Xander", "Ryder", "Nathaniel", "Elliot", "Sean"
        };

        public static List<string> LastNames = new List<string>
        {   "SMITH", "JOHNSON", "WILLIAMS", "BROWN", "JONES", "MILLER", "DAVIS", "GARCIA", "RODRIGUEZ", "WILSON", "MARTINEZ", "ANDERSON", "TAYLOR", "THOMAS HERNANDEZ",
            "RICHARDSON", "WOOD", "WATSON", "BROOKS", "BENNETT GRAY", "JAMES", "REYES", "CRUZ", "HUGHES", "PRICE", "MYERS", "LONG", "FOSTER SANDERS", "ROSS",
            "MORALES", "POWELL", "SULLIVAN", "RUSSELL ORTIZ", "JENKINS", "GUTIERREZ", "PERRY", "BUTLER", "BARNES FISHER", "HENDERSON", "COLEMAN", "SIMMONS", "PATTERSON",
            "JORDAN", "REYNOLDS"
        };

        public static List<Contact> CreateContacts()
        {
            List<Contact> contacts = new List<Contact>();
            Random random = new Random();
            int counter = 0;
            while (counter < FirstNames.Count-1)
            {
                //string firstNameLetter = CapitaliseWord(FirstNames[counter]);
                Contact contact = new Contact();
                contact.FirstName = FirstNames[counter];
                contact.LastName = LastNames[counter];
                //Email = firstNameLetter + "@gmail.com"
                contact.Email = FirstNames[counter] + "@gmail.com";
                contact.Favourite = random.Next() % 2 == 0;              
                contacts.Add(contact);
                counter++;
            }
            return contacts;
        }

        public static string CapitaliseWord(string word)
        {
            word = word.Trim();
            char[] charArr = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0)
                    charArr[i] = char.ToUpper(charArr[i]);
                else
                    charArr[i] = char.ToLower(charArr[i]);
            }
            return new string(charArr);
        }

    }
}
