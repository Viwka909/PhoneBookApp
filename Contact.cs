using System;

namespace PhonebookApp;

public class Contact
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public Contact(int id,
                   string name,
                   string phoneNumber)
    {
        this.Id = id;
        this.Name = name;
        this.PhoneNumber = phoneNumber;

    }

}

