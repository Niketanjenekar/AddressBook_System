using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    public class Contacts_Book
    {
        List<AddressBook> list = new List<AddressBook>();
        
        public void DeleteContact()
        {
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Welcome, You had created a New Contact here : ");

            Console.WriteLine("Please Press Enter to Create a New Registration:");
            Console.ReadLine();
            Console.WriteLine("Please Enter the First name");
            addressBook.firstName = Console.ReadLine();
            Console.WriteLine("Please Enter the Last name");
            addressBook.lastName = Console.ReadLine();
            Console.WriteLine("Please Enter the Address :");
            addressBook.address = Console.ReadLine();
            Console.WriteLine("Please Enter the Name of the City :");
            addressBook.city = Console.ReadLine();
            Console.WriteLine("Please Enter the Name of the State :");
            addressBook.state = Console.ReadLine();
            Console.WriteLine("Please Enter the ZIP-Code :");
            addressBook.zipCode = Console.ReadLine();
            Console.WriteLine("Please Enter the Phone Number:");
            addressBook.phoneNumber = Console.ReadLine();
            Console.WriteLine("Please Enter the Email :");
            addressBook.email = Console.ReadLine();
            list.Add(addressBook);
            foreach (AddressBook item in list)
            {
                Console.WriteLine("First Name = " + item.firstName);
                Console.WriteLine("Last Name = " + item.lastName);
                Console.WriteLine("Address = " + item.address);
                Console.WriteLine("City Name = " + item.city);
                Console.WriteLine("State Name " + item.state);
                Console.WriteLine("Zip-Code = " + item.zipCode);
                Console.WriteLine("Phone Number = " + item.phoneNumber);
                Console.WriteLine("Email " + item.email);
                Console.WriteLine();
            }
            Console.WriteLine("The data has been added");
            
            //To delete the Contact,
            Console.WriteLine("Please enter the First Name to delete the contact :");
            string name = Console.ReadLine();
            if (name.Contains(addressBook.firstName))
            {
                list.Remove(addressBook);
                Console.WriteLine("The Contact of Person is deleted");
            }
            else
            {
                Console.WriteLine("The Name Entered is not Present in the data");
            }
        }
    }
}
