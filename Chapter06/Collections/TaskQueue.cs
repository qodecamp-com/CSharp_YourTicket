using System;
using System.Collections.Generic;

namespace CollectionsExercises;

class TaskQueue
{
    // The queue of tasks
    Queue<string> tasks;

    // Constructor
    public TaskQueue()
    {
        tasks = new Queue<string>();
    }

    // Method to add a task to the queue
    public void AddTask(string task)
    {
        tasks.Enqueue(task);
    }

    // Method to remove a task from the queue
    public void RemoveTask()
    {
        tasks.Dequeue();
    }

    // Method to display the queue of tasks
    public void DisplayTasks()
    {
        Console.WriteLine("List of tasks: ");
        foreach (string task in tasks)
        {
            Console.WriteLine(task);
        }
    }
}