using System;
using System.Collections;

namespace PhonebookApp;

class PhoneBook
{

    public List<Contact> contacts = new List<Contact>();
    public Contact? value;
    string? name;
    string? number;
    bool repeat = true;

    void Main()
    {
        while (repeat)
        {
            Console.WriteLine("Select your action \n Press 1 to add contact \n Press 2 to remove contact \n Press 3 to search contact by name \n Press 4 to display all contacts \n press 0 to exit");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Input Contact's name");
                    name = Console.ReadLine();
                    Console.WriteLine("Input Contacts's phone number");
                    number = Console.ReadLine();
                    Push(name, number);
                    break;
                case "2":
                    Console.WriteLine("Input Contact's phone number");
                    number = Console.ReadLine();
                    Remove(number);
                    break;
                case "3":
                    Console.WriteLine("Input Contact's name");
                    name = Console.ReadLine();
                    FindByName(name);
                    break;
                case "4":
                    ShowAll();
                    break;
                case "0":
                    repeat = false;
                    break;
            }
        }

    }
    public void Push(string _name, string _phoneNumber)
    {
        int hash = _phoneNumber.GetHashCode();
        value = new Contact(hash, _name, _phoneNumber);
        contacts.Add(value);
    }
    public void Remove(string _phoneNumber)
    {
        contacts.RemoveAll(x => x.PhoneNumber == _phoneNumber);
    }
    public void FindByName(string _name)
    {
        List<Contact> foundNames = contacts.FindAll(name => name.Name == _name);
        foreach (Contact contact in foundNames)
        {
            Console.WriteLine("Id : {0} Name : {1} Phone Number :{2}", contact.Id, contact.Name, contact.PhoneNumber);
        }
    }
    public void ShowAll()
    {
        foreach (Contact contact in contacts)
        {
            Console.WriteLine("Id : {0} Name : {1} Phone Number :{2}", contact.Id, contact.Name, contact.PhoneNumber);
        }
    }
}