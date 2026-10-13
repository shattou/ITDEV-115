using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBook
{
    class ContactS
    {
        private string fileName = "addresses.txt";
        private Contact[] myContacts;
        public static int NO_OF_CONTACTS = 4;

        public ContactS()
        {
            myContacts = new Contact[NO_OF_CONTACTS];
        }
        public string GetAddress(int index)
        {
            return myContacts[index].Address;
        }
        public string GetCity(int index)
        {
            return myContacts[index].City;
        }
        public string GetEmail(int index)
        {
            return myContacts[index].EmailAddress;
        }
        public string GetFirstName(int index)
        {
            return myContacts[index].FirstName;
        }
        public string GetLastName(int index)
        {
            return myContacts[index].LastName;
        }
        public string GetPhone(int index)
        {
            return myContacts[index].Phone;
        }
        public string GetState(int index)
        {
            return myContacts[index].State;
        }
        public string GetZip(int index)
        {
            return myContacts[index].ZipCode;
        }

        public void ReadContacts()
        {
            string address;
            string city;
            string email;
            string fName;
            string lName;
            string phone;
            string state;
            string zip;
            StreamReader reader = new StreamReader(fileName);

            for (int index = 0; index < myContacts.Length; index++)
            {
                fName = reader.ReadLine();
                lName = reader.ReadLine();
                address = reader.ReadLine();
                city = reader.ReadLine();
                state = reader.ReadLine();
                zip = reader.ReadLine();
                phone = reader.ReadLine();
                email = reader.ReadLine();

                myContacts[index] = new Contact(address, city, email, fName, lName, phone, state, zip);
            }
        }
    }
}
