namespace CollectionsExercises;
class Program
{
    static void Main(string[] args)
    {
        //Question 1
        NameListManager();
        Console.WriteLine("----------------");

        //Question 2
        WebPageHistory();
        Console.WriteLine("----------------");

        //Question 3
        TaskQueueDriver();
        Console.WriteLine("----------------");

        //Question 4
        StudentGradesDriver();
        Console.WriteLine("----------------");

        //Question 5
        ContactListDriver();
    }

    private static void NameListManager()
    {
        // Create a NameList object
        NameList nameList = new NameList();

        // Add some names to the list
        nameList.AddName("Alice");
        nameList.AddName("Bob");
        nameList.AddName("Charlie");

        // Display the list of names
        nameList.DisplayNames();

        // Remove a name from the list
        nameList.RemoveName("Bob");

        // Display the updated list of names
        nameList.DisplayNames();
    }

    private static void WebPageHistory()
    {
        WebpageHistory webpageHistory = new WebpageHistory();
        webpageHistory.VisitNewWebPage("http://www.google.com");
        webpageHistory.VisitNewWebPage("http://www.microsoft.com");
        webpageHistory.VisitNewWebPage("http://www.apple.com");

        // Display the current web page
        Console.WriteLine("Current web page: " + webpageHistory.CurrentPage);

        // Navigate back in the history
        Console.WriteLine("Navigating back in the history...");
        webpageHistory.GoBack();
        Console.WriteLine("Current web page: " + webpageHistory.CurrentPage);

        // Navigate back in the history again
        Console.WriteLine("Navigating back in the history...");
        webpageHistory.GoBack();
        Console.WriteLine("Current web page: " + webpageHistory.CurrentPage);

        // Navigate forward in the history
        Console.WriteLine("Navigating forward in the history...");
        webpageHistory.VisitNewWebPage("http://www.microsoft.com");
        Console.WriteLine("Current web page: " + webpageHistory.CurrentPage);
    }

    private static void TaskQueueDriver()
    {
        // Create a TaskQueue object
        TaskQueue taskQueue = new TaskQueue();

        // Add some tasks to the queue
        taskQueue.AddTask("Task 1");
        taskQueue.AddTask("Task 2");
        taskQueue.AddTask("Task 3");

        // Display the queue of tasks
        taskQueue.DisplayTasks();

        // Remove a task from the queue
        taskQueue.RemoveTask();

        // Display the updated queue of tasks
        taskQueue.DisplayTasks();
    }

    private static void StudentGradesDriver()
    {
        // Create a StudentGrades object
        StudentGrades studentGrades = new StudentGrades();

        // Add some students to the dictionary
        studentGrades.AddStudent("Alice", 90);
        studentGrades.AddStudent("Bob", 80);
        studentGrades.AddStudent("Charlie", 70);

        // Display the dictionary of student grades
        studentGrades.DisplayGrades();

        // Update a student's grade
        studentGrades.UpdateStudent("Bob", 85);

        // Display the updated dictionary of student grades
        studentGrades.DisplayGrades();

        // Remove a student from the dictionary
        studentGrades.RemoveStudent("Charlie");

        // Display the updated dictionary of student grades
        studentGrades.DisplayGrades();
    }

    private static void ContactListDriver()
    {
        ContactList contactList = new ContactList();

        // Add some contacts to the list
        contactList.AddContact(new Contact("Alice", "123-456-7890"));
        contactList.AddContact(new Contact("Bob", "123-456-7891"));
        contactList.AddContact(new Contact("Charlie", "123-456-7892"));

        // Search for a contact by name
        Contact alice = contactList.SearchByName("Alice");
        if (alice != null)
        {
            Console.WriteLine(alice.Name + ": " + alice.PhoneNumber);
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }

        // Search for a contact by phone number
        Console.WriteLine("Searching for Bob using his phone number...");
        Contact bob = contactList.SearchByPhoneNumber("123-456-7891");
        if (bob != null)
        {
            Console.WriteLine("Contact Found -- " + bob.Name + ": " + bob.PhoneNumber);
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

}
