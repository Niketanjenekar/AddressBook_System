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
        public void Contact()
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
                Console.WriteLine("First Name = "+ item.firstName + "\n" +"Last Name "+ item.lastName +"\n"+ "Address = "+ item.address +
                                  "City Name = " + item.city + "\n" + "State Name " + item.state + "\n" + "Zip-Code = " + item.zipCode +
                                  "Phone Number = " + item.phoneNumber + "\n" + "Email " + item.email+"\n" );
            }
            
            
            
            Console.WriteLine("The data has been added");
        }
    }
}
