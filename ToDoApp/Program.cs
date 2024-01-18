using System;
using System.Collections.Generic;

class Program
{
    static List<string> todoList = new List<string>();

    static void Main()
    {
        Console.WriteLine("Welcome to the To-Do List App!");

        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowTodoList();
                    break;
                case "2":
                    AddTodoItem();
                    break;
                case "3":
                    RemoveTodoItem();
                    break;
                case "4":
                    ClearTodoList();
                    break;
                case "5":
                    Console.WriteLine("Exiting the To-Do List App. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Show To-Do List");
        Console.WriteLine("2. Add To-Do Item");
        Console.WriteLine("3. Remove To-Do Item");
        Console.WriteLine("4. Clear To-Do List");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
    }

    static void ShowTodoList()
    {
        Console.WriteLine("\nTo-Do List:");

        if (todoList.Count == 0)
        {
            Console.WriteLine("No items in the To-Do list.");
        }
        else
        {
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
        }
    }

    static void AddTodoItem()
    {
        Console.Write("Enter the new To-Do item: ");
        string newItem = Console.ReadLine();
        todoList.Add(newItem);
        Console.WriteLine("To-Do item added successfully.");
    }

    static void RemoveTodoItem()
    {
        ShowTodoList();

        if (todoList.Count == 0)
        {
            Console.WriteLine("No items to remove.");
        }
        else
        {
            Console.Write("Enter the number of the item to remove: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= todoList.Count)
            {
                todoList.RemoveAt(index - 1);
                Console.WriteLine("To-Do item removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid item number.");
            }
        }
    }

    static void ClearTodoList()
    {
        todoList.Clear();
        Console.WriteLine("To-Do list cleared successfully.");
    }
}
