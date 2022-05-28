using System;

namespace AddressBookProblemSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program in AddressBook");
            CreateContact contact = new CreateContact();



            while (true)
            {

                Console.WriteLine("\nEnter the number :\n1)Creatingcontacts\n2)Edit Details\n3)Remove Contacts\n4)Adding multiple contacts\n5)Output Details\n6)Adding Unique Contacts\n7)Display unique contacts" +
                    "\n8)Search Person by city or State\n9)Count Persons by city or State\n10)Contacts by city using Dictionary\n11)Contacts by State using Dictionary\n12)Sorting Details By FirstName\n13)Sorting Details By State\n14)Sorting Details By City\n15)Sorting Details By Zip");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contact.Contact();
                        break;
                    case 2:
                        contact.EditContact();
                        break;
                    case 3:
                        contact.DeleteContact();
                        break;
                    case 4:
                        Console.WriteLine("Enter the number of contacts you want");
                        int n = Convert.ToInt32(Console.ReadLine());
                        contact.AddMultipleContact(n);
                        break;
                    case 5:
                        contact.Output();
                        break;
                    case 6:
                        contact.AddUniqueName();
                        break;
                    case 7:
                        contact.DisplayUniqueContact();
                        break;
                    case 8:
                        contact.SearchPersonByCityState();
                        break;
                    case 9:
                        contact.CountPersonByCityState();
                        break;
                    case 10:
                        contact.ContactBycity_Dictionary();
                        contact.DisplayContactsByCity_Dictionary();
                        break;
                    case 11:
                        contact.ContactByState_Dictionary();
                        contact.DisplayContactsByState_Dictionary();
                        break;
                    //case 12:
                    //    contact.SortingDetailsByName();
                    //    break;
                    //case 13:
                    //    Console.WriteLine("Sorting details by City");
                    //    contact.SortingDetailsByCity();
                    //    break;
                    //case 14:
                    //    Console.WriteLine("Sorting details by State");
                    //    contact.SortingDetailsByState();
                    //    break;
                    //case 15:
                    //    Console.WriteLine("Sorting details by Zip");
                    //    contact.SortingDetailsByZip();
                    //    break;

                }
            }
        }
    }
}
