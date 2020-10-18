using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace AddressBookProblem
{
   public class AddressCheck
    {
        /// Creating Dictionary to store the address details
        /// Storing the data in the address book map dictionary after creating it
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
        
        /// Editing the details of the address book
        /// Taking input from the user and updating the address book after taking the new name
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
        /// Creating a method to delete the details of a record
        /// Taking the input from the user and deleting the corresponding address
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
                    Console.WriteLine("Name:"+adBook.firstName);
                    Console.WriteLine("Last name: "+adBook.lastName);
                    Console.WriteLine("Address: "+adBook.address);
                    Console.WriteLine("State: "+adBook.state);
                    Console.WriteLine("Zip code: "+adBook.zip);
                    Console.WriteLine("Phone: "+adBook.phoneNo);
                    Console.WriteLine("Email: "+adBook.emailId);
                }
            }
        }
        /// Getting the exisitng address books
        /// Prints out all the exisitng address books
        public static void GetAddressBook() {
            Console.WriteLine("Exisiting address books are");
            if (addresssBookMap.Count > 0) {
                foreach (var value in addresssBookMap) {
                    Console.WriteLine(value.Value.firstName+"'s Address Book:");
                    PrintAddress(value.Value.firstName);
                    Console.WriteLine("-------------------------");
                }
            }
        }

        //Method to print put a person's detail by the name of the city 
        //Getting input from the user and giving out the existing field records
        public static void SearchByCity() {
            Console.WriteLine("Enter name of the city");
            string city = Console.ReadLine();
            foreach (KeyValuePair<string, AddressBookMain> keys in addresssBookMap) {
                AddressBookMain val = keys.Value;
                if (val.address.Contains(city))
                {
                    Console.WriteLine(val.firstName+"'s Address:");
                    PrintAddress(val.firstName);
                }
                else {
                    Console.WriteLine("Address wasn't found");
                }
            }
        }
        /// Method to print out a person's detail by his state
        /// Input taken from the user and searched accordingly
        public static void SearchByState() {
            Console.WriteLine("Enter the name of the state");
            string state = Console.ReadLine();
            foreach (KeyValuePair<string, AddressBookMain> keys in addresssBookMap)
            {
                AddressBookMain val = keys.Value;
                if (val.state.Contains(state))
                {
                    Console.WriteLine(val.firstName+"'s Address");
                    PrintAddress(val.firstName);
                }
                else
                {
                    Console.WriteLine("Address wasn't found");
                }
            }
        } 
    }
}
