﻿using System;
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
            
            
            Contacts_Book contactOne = new Contacts_Book();
            
            contactOne.DeleteContact();
                                    
            Console.ReadLine();
        }
    }
}
