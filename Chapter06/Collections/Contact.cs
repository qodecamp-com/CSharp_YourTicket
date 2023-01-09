namespace CollectionsExercises;

class Contact
{
    // The name and phone number of the contact
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    // Constructor
    public Contact(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
    }
}