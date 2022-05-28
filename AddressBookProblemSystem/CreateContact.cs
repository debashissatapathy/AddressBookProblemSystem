using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookProblemSystem
{
    public class CreateContact
    {
        public List<Contacts> People = new List<Contacts>();
        public Dictionary<string, List<Contacts>> dict = new Dictionary<string, List<Contacts>>();

        public void Contact()
        {
            Contacts contact = new Contacts();
            
            int Flag = 0;
            Console.WriteLine("Enter First Name : ");
            contact.FirstName = Console.ReadLine();


            string AddFirstName = contact.FirstName;
            foreach (var data in People)
            {
                if (People.Exists(data => data.FirstName == AddFirstName))
                {
                    Flag++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("This FirstName already Exist! Try another name ");
                    Console.ResetColor();
                    break;
                }

            }
            if (Flag == 0)
            {
                Console.WriteLine("Enter Last Name : ");
                contact.LastName = Console.ReadLine();

                Console.WriteLine("Enter Email : ");
                contact.Email = Console.ReadLine();

                Console.WriteLine("Enter Phone Number : ");
                contact.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Enter Address : ");
                contact.Address = Console.ReadLine();

                Console.WriteLine("Enter City : ");
                contact.City = Console.ReadLine();

                Console.WriteLine("Enter Zip : ");
                contact.Zip = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter State : ");
                contact.State = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Contact added Sucessfully.");
                Console.ResetColor();

                Console.WriteLine("\n");

            }
            People.Add(contact);
        }
        public void EditContact()
        {
            Console.WriteLine("Enter first name to search in People");
            string name = Console.ReadLine();

            foreach(var data in People)
            {
                if (data.FirstName != name)
                {
                    Console.WriteLine("This contact doesn't exist.");
                }
                else if (data.FirstName == name)
                {
                    Console.WriteLine("Choose option from below for edit\n1. First Name\n2. Last Name\n3. Address\n4. City\n5. State\n" +
                                        "6. Zip\n7. Phone Number\n8. Email");
                    int choose = int.Parse(Console.ReadLine());
                    switch(choose)
                    {
                        case 1:
                            Console.WriteLine("Please enter a first name for edit");
                            string Fname = Console.ReadLine();
                            data.FirstName = Fname;
                            break;
                        case 2:
                            Console.WriteLine("Please enter a last name for edit");
                            string Lname = Console.ReadLine();
                            data.LastName = Lname;
                            break;
                        case 3:
                            Console.WriteLine("Please enter an address for edit");
                            string address = Console.ReadLine();
                            data.Address = address;
                            break;
                        case 4:
                            Console.WriteLine("Please enter an city for edit");
                            string city = Console.ReadLine();
                            data.City = city;
                            break;
                        case 5:
                            Console.WriteLine("Please enter an state for edit");
                            string state = Console.ReadLine();
                            data.State = state;
                            break;
                        case 6:
                            Console.WriteLine("Please enter an zip for edit");
                            int zip = int.Parse(Console.ReadLine());
                            data.Zip = zip;
                            break;
                        case 7:
                            Console.WriteLine("Please enter an phonenumber for edit");
                            string phonenumber = Console.ReadLine();
                            data.PhoneNumber = phonenumber;
                            break;
                        case 8:
                            Console.WriteLine("Please enter an Email for edit");
                            string email = Console.ReadLine();
                            data.Email = email;
                            break;
                        default:
                            Console.WriteLine(" Wrong input,Please choose from above options : ");
                            break;
                    }
                }
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter first name to search in People");
            string name = Console.ReadLine();

            foreach(var data in People)
            {
                if (People.Contains(data))
                {
                    if (data.FirstName == name)
                    {
                        People.Remove(data);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("contat deleted sucessfully.");
                        Console.ResetColor();

                        return;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Contact person is not exist in People.");
                        Console.ResetColor();
                    }
                }
                              
                
            }
             
        }
        public void AddMultipleContact(int n)
        {
            while (n > 0)
            {
                Contact();
                n--;
            }

        }
        public void AddUniqueName()
        {
            Console.WriteLine("Enter first name in People");
            string name = Console.ReadLine();
            foreach(var data in People)
            {
                if (data.FirstName == name)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0} is already exist in People. Please enter unique name to save.");
                    Console.ResetColor();
                    string uniqueName = Console.ReadLine();
                    if (dict.ContainsKey(uniqueName))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("This unique name already exist.");
                        Console.ResetColor();
                    }
                    dict.Add(uniqueName, People);
                    return;
                }
            }
            Console.WriteLine("This contactlist doesn't exist, please create a contactlist");
            return;
        }
        public void DisplayUniqueContact()
        {
            Console.WriteLine("Enter the Uniquename in People");
            string name = Console.ReadLine();
            foreach (var contacts in dict)
            {
                //Console.WriteLine("The details of " + name + " are \n" + contacts.Value);
                if (contacts.Key.Contains(name))
                {
                    foreach (var contact in contacts.Value)
                    {
                        Console.WriteLine("The details of " + name + " are \n" + "Name: " + contact.FirstName + " " + contact.LastName + "\n" + "Email: " + contact.Email + "\n" +
                            "Phone Number: " + contact.PhoneNumber + "\n" + "Address: " + contact.Address + "\n" + "city: " + contact.City + "\n" + "Zip: " + contact.Zip + "\n" + "state: " + contact.State);
                        return;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("this unique name doesn't exist");
                    Console.ResetColor();
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This Uniquelist doesn't exist, please create an Uniquelist");
            Console.ResetColor();
        }
        public void Output()
        {
            foreach (var data in People)
            {
                Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                Console.WriteLine("Email ID : " + data.Email);
                Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                Console.WriteLine("Address : " + data.Address);
                Console.WriteLine("City : " + data.City);
                Console.WriteLine("Zip : " + data.Zip);

                Console.WriteLine("\n");

            }
        }
        public void SearchPersonByCityState()
        {
            Console.WriteLine("Please enter the name of City or State:");

            string CityOrState = Console.ReadLine();
            foreach (var data in People)
            {
                string getCity = data.City;
                string GetState = data.State;
                if (People.Exists(data => (getCity == CityOrState || GetState == CityOrState)))
                {
                    Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Email ID : " + data.Email);
                    Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                    Console.WriteLine("Address : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State : " + data.State);
                    Console.WriteLine("Zip : " + data.Zip);
                    Console.WriteLine("\n");
                }

            }
        }
        public void CountPersonByCityState()
        {
            Console.WriteLine("Please enter the name of City or State:");
            string CityOrState = Console.ReadLine();

            int count = 0;
            foreach (var data in People)
            {
                string GetCity = data.City;
                string GetState = data.State;
                if (People.Exists(data => (GetCity == CityOrState || GetState == CityOrState)))
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} Persons in {1}:", count, CityOrState);
        }
        public void ContactBycity_Dictionary()
        {
            try
            {
                var data = People.GroupBy(x => x.City);
                foreach (var cities in data)
                {
                    List<Contacts> cityList = new List<Contacts>();
                    foreach (var city in cities)
                    {
                        cityList.Add(city);
                    }
                    dict.Add(cities.Key, cityList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void DisplayContactsByCity_Dictionary()
        {
            if (dict.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (dict.Count >= 1)
            {
                foreach (KeyValuePair<string, List<Contacts>> addressBooks in dict)
                {
                    Console.WriteLine("Contacts From City: " + addressBooks.Key);
                    foreach (Contacts items in addressBooks.Value)
                    {
                        Console.WriteLine($"Name: {items.FirstName + " " + items.LastName}, Phone Number: {items.PhoneNumber}, City: {items.City}, State: {items.State}" +
                            $"\n Address: {items.Address}, Zipcode: {items.Zip}, Email: {items.Email}");
                        Console.WriteLine();
                    }
                }
            }
        }
        public void ContactByState_Dictionary()
        {
            try
            { 
                var data = People.GroupBy(x => x.State);
                foreach (var state in data)
                {
                    List<Contacts> StateList = new List<Contacts>();
                    foreach (var States in state)
                    {
                        StateList.Add(States);
                    }
                    dict.Add(state.Key, StateList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void DisplayContactsByState_Dictionary()
        {
            if (dict.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (dict.Count >= 1)
            {
                foreach (KeyValuePair<string, List<Contacts>> addressBooks in dict)
                {
                    Console.WriteLine("Contacts From State: " + addressBooks.Key);
                    foreach (Contacts items in addressBooks.Value)
                    {
                        Console.WriteLine($"Name: {items.FirstName + " " + items.LastName}, Phone Number: {items.PhoneNumber}, City: {items.City}, State: {items.State}" +
                            $"\n Address: {items.Address}, Zipcode: {items.Zip}, Email: {items.Email}");
                        Console.WriteLine();
                    }
                }
            }
        }
        public void SortDetailByName()
        {
            foreach(var data in People.OrderBy(s => s.FirstName).ToList())
            {
               if(People.Contains(data))
                {
                    Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Email ID : " + data.Email);
                    Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                    Console.WriteLine("Address : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State : " + data.State);
                    Console.WriteLine("Zip : " + data.Zip);
                    Console.WriteLine("\n");
               }
            }
        }
        public void SortDetailByCity()
        {
            foreach (var data in People.OrderBy(s => s.City).ToList())
            {
                if (People.Contains(data))
                {
                    Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Email ID : " + data.Email);
                    Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                    Console.WriteLine("Address : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State : " + data.State);
                    Console.WriteLine("Zip : " + data.Zip);
                    Console.WriteLine("\n");
                }
            }
        }
        public void SortDetailByState()
        {
            foreach (var data in People.OrderBy(s => s.State).ToList())
            {
                if (People.Contains(data))
                {
                    Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Email ID : " + data.Email);
                    Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                    Console.WriteLine("Address : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State : " + data.State);
                    Console.WriteLine("Zip : " + data.Zip);
                    Console.WriteLine("\n");
                }
            }
        }
        public void SortDetailByZip()
        {
            foreach (var data in People.OrderBy(s => s.Zip).ToList())
            {
                if (People.Contains(data))
                {
                    Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Email ID : " + data.Email);
                    Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                    Console.WriteLine("Address : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State : " + data.State);
                    Console.WriteLine("Zip : " + data.Zip);
                    Console.WriteLine("\n");
                }
            }
        }


    }
}

