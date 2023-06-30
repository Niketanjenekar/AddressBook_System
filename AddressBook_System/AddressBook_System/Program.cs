using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System Problem : ");

            //*********************************Day-10 Assignments*********************************

            Console.WriteLine("Usecase 5 for Adding Multiple Contacts to Address Book");

            Contacts_Book contactOne = new Contacts_Book();            
            contactOne.AddContact("Niketan", "Jenekar", "Wani", "Yavatmal", "Maharashtra", 
                                     "445304", "9767999311", "niketanjenekar31@gmail.com");
            
            Contacts_Book contactTwo = new Contacts_Book();
            contactTwo.AddContact("Nikhil", "Jenekar", "Nagpur", "Nagpur", "Maharashtra",
                                     "445001", "9049639324", "niketan9767999311@gmail.com");

            Contacts_Book contactThree = new Contacts_Book();
            contactThree.AddContact("Shubham", "Borkute", "Wani", "Yavatmal", "Maharashtra",
                                     "445302", "8856854218", "shubhambrkt@gmail.com");
                                    
            Console.ReadLine();
        }
    }
}
