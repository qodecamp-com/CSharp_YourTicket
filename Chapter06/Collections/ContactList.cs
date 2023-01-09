namespace CollectionsExercises;

class ContactList
{
    // The list of contacts
    List<Contact> contacts;

    // Constructor
    public ContactList()
    {
        contacts = new List<Contact>();
    }

    // Method to add a contact to the list
    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
    }

    // Method to search for a contact by name
    public Contact SearchByName(string name)
    {
        foreach (Contact contact in contacts)
        {
            if (contact.Name == name)
            {
                return contact;
            }
        }

        return null;
    }

    // Method to search for a contact by phone number
    public Contact SearchByPhoneNumber(string phoneNumber)
    {
        foreach (Contact contact in contacts)
        {
            if (contact.PhoneNumber == phoneNumber)
            {
                return contact;
            }
        }

        return null;
    }
}