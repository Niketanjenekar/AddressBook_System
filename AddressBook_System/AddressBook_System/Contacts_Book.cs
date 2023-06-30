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
                Console.WriteLine("First Name = "+ item.firstName);
                Console.WriteLine("Last Name "+ item.lastName);
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
        public void EditContact()
        {
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Please enter the First Name to edit the contact :");
            string name = Console.ReadLine();
            if (name == addressBook.firstName)
            {
                Console.WriteLine("select an option to edit");

                Console.WriteLine("1. First Name");
                Console.WriteLine("2. Last Name");
                Console.WriteLine("3. Address");
                Console.WriteLine("4. City Name");
                Console.WriteLine("5. State Name");
                Console.WriteLine("6. Zip-Code");
                Console.WriteLine("7. Phone Number");
                Console.WriteLine("8. Email");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please enter the Correct Detail");
                        string nameOne = Console.ReadLine();
                        addressBook.firstName = nameOne;
                        Console.WriteLine("The edited First name is : " + addressBook.firstName);
                        break;
                    case 2:
                        Console.WriteLine("Please enter the Correct Detail");
                        string nameTwo = Console.ReadLine();
                        addressBook.lastName = nameTwo;
                        Console.WriteLine("The edited Lase name is : " + addressBook.lastName);
                        break;
                    case 3:
                        Console.WriteLine("Please enter the Correct Detail");
                        string nameThree = Console.ReadLine();
                        addressBook.address = nameThree;
                        Console.WriteLine("The edited address is : " + addressBook.address);
                        break;
                    case 4:
                        Console.WriteLine("Please enter the Correct Detail");
                        string nameFour = Console.ReadLine();
                        addressBook.city = nameFour;
                        Console.WriteLine("The edited City is : " + addressBook.city);
                        break;
                    case 5:
                        Console.WriteLine("Please enter the Correct Detail");
                        string nameFive = Console.ReadLine();
                        addressBook.state = nameFive;
                        Console.WriteLine("The edited State is : " + addressBook.state);
                        break;
                    case 6:
                        Console.WriteLine("Please enter the Correct Detail");
                        string nameSix = Console.ReadLine();
                        addressBook.zipCode = nameSix;
                        Console.WriteLine("The edited Zip_Code is : " + addressBook.zipCode);
                        break;
                    case 7:
                        Console.WriteLine("Please enter the Correct Detail");
                        string nameSeven = Console.ReadLine();
                        addressBook.phoneNumber = nameSeven;
                        Console.WriteLine("The edited Phone Number is : " + addressBook.phoneNumber);
                        break;
                    case 8:
                        Console.WriteLine("Please enter the Correct Detail");
                        string nameEight = Console.ReadLine();
                        addressBook.email = nameEight;
                        Console.WriteLine("The edited City is : " + addressBook.email);
                        break;
                    default:
                        Console.WriteLine("Please enter the correct choice :");
                        break;
                }
            }
            else
            {
                Console.WriteLine("The Name Entered is not Present in the data");
            }
        }
    }
}
