using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    public class Contacts_Book : Program
    {
        List<AddressBook> list = new List<AddressBook>();
        public void AddContact(string fName, string sName, string adress, string cities, string states, 
                                string zip_code, string phone, string eMail)
        {
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Welcome, You had created a New Contact here : ");
            addressBook.firstName = fName;
            addressBook.lastName = sName;
            addressBook.address = adress;
            addressBook.city = cities;
            addressBook.state = states;
            addressBook.zipCode = zip_code;
            addressBook.phoneNumber = phone;
            addressBook.email = eMail;
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
            
            
        }
    }
}
