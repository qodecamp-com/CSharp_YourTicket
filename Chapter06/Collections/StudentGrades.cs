using System;
using System.Collections.Generic;

class StudentGrades
{
    // The dictionary of student grades
    Dictionary<string, int> grades;

    // Constructor
    public StudentGrades()
    {
        grades = new Dictionary<string, int>();
    }

    // Method to add a student to the dictionary
    public void AddStudent(string name, int grade)
    {
        grades.Add(name, grade);
    }

    // Method to update a student's grade in the dictionary
    public void UpdateStudent(string name, int grade)
    {
        grades[name] = grade;
    }

    // Method to remove a student from the dictionary
    public void RemoveStudent(string name)
    {
        grades.Remove(name);
    }

    // Method to display the dictionary of student grades
    public void DisplayGrades()
    {
        Console.WriteLine("List of student grades: ");
        foreach (KeyValuePair<string, int> entry in grades)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
    }
}