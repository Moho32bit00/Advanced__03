using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_03
{
    #region Exercise 3: Phone Book
    public static  class ContactsHelper
    {
        public static void GetAllContacts(Dictionary<int , string> con)
        {
            foreach (var contact in con)
            {
                Console.WriteLine($"Name : {contact.Value} , Phone Number : {contact.Key}");
            }
            Console.WriteLine("======================================");
        }
    }
    #endregion
}
