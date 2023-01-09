using System.Collections;

namespace CollectionsExercises;

class NameList
    {
        // The list of names
        ArrayList names;

        // Constructor
        public NameList()
        {
            names = new ArrayList();
        }

        // Method to add a name to the list
        public void AddName(string name)
        {
            names.Add(name);
        }

        // Method to remove a name from the list
        public void RemoveName(string name)
        {
            names.Remove(name);
        }

        // Method to display the list of names
        public void DisplayNames()
        {
            Console.WriteLine("List of names: ");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }