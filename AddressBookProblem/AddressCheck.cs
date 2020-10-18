using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace AddressBookProblem
{
   public class AddressCheck
    {
        //Creating a dictionary to store the address book
         static Dictionary<string, AddressBookMain> addresssBookMap= new Dictionary<string, AddressBookMain>();
        //Adding the values to the dictionary
        public static void AddToAddressBook()
        {
            Console.WriteLine("Enter firstname");
            string firstName = Console.ReadLine();
            if (addresssBookMap.ContainsKey(firstName))
            {
                Console.WriteLine("The user name already exists");
            }
            else
            {
                Console.WriteLine("Enter lastname");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter address");
                string address = Console.ReadLine();
                Console.WriteLine("Enter state");
                string state = Console.ReadLine();
                Console.WriteLine("Enter zip");
                int zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter phone number");
                double phoneNo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter email id");
                string emailId = Console.ReadLine();
                AddressBookMain addressBookMain = new AddressBookMain(firstName, lastName, address, state, zip, phoneNo, emailId);
                addresssBookMap.Add(firstName, addressBookMain);
                PrintAddress(firstName);
            }
            
            
        }
        public string GetFirstName(string firstName)
        {
            return addresssBookMap[firstName].firstName;
        }

        //Method to edit the details
        public static void EditDetails()
        {
            Console.WriteLine("Enter the name you want to edit");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the new name");
            string newName = Console.ReadLine();
            if (addresssBookMap.ContainsKey(name))
            {
                addresssBookMap[name].firstName = newName;
            }
            AddressBookMain addressBook = new AddressBookMain(newName, addresssBookMap[name].lastName, addresssBookMap[name].address, addresssBookMap[name].state, addresssBookMap[name].zip, addresssBookMap[name].phoneNo, addresssBookMap[name].emailId);
            addresssBookMap.Add(newName, addressBook);
            Console.WriteLine("Edited details are");
            PrintAddress(newName);
        }
        //Method to delete records
        public static void DeleteDetails()
        {
            Console.WriteLine("Enter the name that you want to delete");
            string name = Console.ReadLine();
            if (addresssBookMap.ContainsKey(name))
            {
                addresssBookMap.Remove(name);
                Console.WriteLine("Records having the first name " + name + " are deleted");
            }

        }

        //Printing the values from the dictionary
        public static void PrintAddress(String key)
        {

            foreach (KeyValuePair<string, AddressBookMain> items in addresssBookMap)
            {
                AddressBookMain adBook = items.Value;
                if (adBook.firstName.Equals(key))
                {
                    Console.WriteLine(adBook.firstName);
                    Console.WriteLine(adBook.lastName);
                    Console.WriteLine(adBook.address);
                    Console.WriteLine(adBook.state);
                    Console.WriteLine(adBook.zip);
                    Console.WriteLine(adBook.phoneNo);
                    Console.WriteLine(adBook.emailId);
                }
            }
        }
        public static void GetAddressBook() {
            Console.WriteLine("Exisiting address books are");
            if (addresssBookMap.Count > 0) {
                foreach (var value in addresssBookMap) {
                    Console.WriteLine("Name: " +value.Value.firstName);
                    Console.WriteLine("Last name: " + value.Value.lastName);
                    Console.WriteLine("Address: "+value.Value.address);
                    Console.WriteLine("State: " +value.Value.state);
                    Console.WriteLine("Zip: "+value.Value.zip);
                    Console.WriteLine("Phone: "+value.Value.phoneNo);
                    Console.WriteLine("Email: "+value.Value.emailId);
                }
            }
            
        }
    }
}
