using System;
using System.Collections.Generic;
using System.IO;

namespace calculate_sum_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Admin type 1 \nEmployee type 2");
                    int ee = int.Parse(Console.ReadLine());


                    if (ee == 1)
                    {
                        Progect.TeamA.ClassA.print();
                    }
                    else if (ee == 2)
                    {
                        Progect.TeamB.ClassA.print();
                    }

                    else
                    {
                        Console.WriteLine("Please enter a correct number\nTry again");
                        continue;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Please enter a correct number\nTry again" + ex);
                    continue;
                }

            }

        }

    }
}
namespace Progect
{
    namespace TeamA
    {
        class ClassA
        {
            static readonly string filename1 = @"C:\Users\alaas\source\repos\Management of employees 11\Management of employees 11\Admin.text";
            public static void print()
            {
                int menuItem = -1;
                while (menuItem != 0)
                {
                    menuItem = menu();
                    switch (menuItem)
                    {
                        case 1:
                            AddItem();
                            break;
                        case 2:
                            ShowList();
                            break;
                        case 3:
                            RemoveItem();
                            break;
                        case 4:
                            Progect.TeamB.ClassA.print();
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Dont recognlize input");
                            break;

                    }
                }
            }
            static void AddItem()
            {
                Console.WriteLine("Add Employee");
                StreamWriter outFile = File.AppendText(filename1);
                Console.Write("Enter an item: ");
                string item = Console.ReadLine();
                outFile.WriteLine(item);
                outFile.Close();
            }
            static void RemoveItem()
            {
                int choice;
                ShowList();
                Console.Write("Which Employee do you want to remove? ");
                choice = Convert.ToInt32(Console.ReadLine());
                List<string> items = new List<string>();
                int number = 1;
                string item;
                StreamReader inFile = new StreamReader(filename1);
                while (inFile.Peek() != -1)
                {
                    item = inFile.ReadLine();
                    if (number != choice)
                        items.Add(item);
                    ++number;
                }
                inFile.Close();
                StreamWriter outFile = new StreamWriter(filename1);
                for (int i = 0; i < items.Count; i++)
                    outFile.WriteLine(items[i]);
                outFile.Close();

            }
            static int menu()
            {
                int choice;
                Console.WriteLine("\nWelcom to Admin page");
                Console.WriteLine("\t1.Add Employee to  list");
                Console.WriteLine("\t2.Show Employee list");
                Console.WriteLine("\t3.Remove Employee from the list");
                Console.WriteLine("\t4.Change to Employee status");
                Console.WriteLine("\t0.Exit the program and go back to start!");
                Console.WriteLine();
                Console.WriteLine("Enter your choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                return choice;
            }
            static void ShowList()
            {
                Console.WriteLine("\nTo-do List : ");
                using (var inFile = new StreamReader(filename1))
                {
                    string line;
                    int number = 1;
                    while (inFile.Peek() != -1)
                    {
                        line = inFile.ReadLine();
                        Console.Write(number + " ");
                        Console.WriteLine(line);
                        ++number;
                    }
                    Console.WriteLine();
                    inFile.Close();
                }
            }
        }
    }
}
namespace Progect
{
    namespace TeamB
    {
        class ClassA
        {
            static readonly string filename = @"C:\Users\alaas\source\repos\Management of employees 11\Management of employees 11\Employee.text";
            public static void print()
            {
                int menuItem = -1;
                while (menuItem != 0)
                {
                    menuItem = menu();
                    switch (menuItem)
                    {
                        case 1:
                            AddItem();
                            break;
                        case 2:
                            ShowList();
                            break;
                       
                        case 3:
                            Progect.TeamA.ClassA.print();
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Dont recognlize input");
                            break;

                    }
                }
            }
            static void AddItem()
            {
                Console.WriteLine("User name and pasword");
                StreamWriter outFile = File.AppendText(filename);
                Console.Write("Enter an item: ");
                string item = Console.ReadLine();
                outFile.WriteLine(item);
                outFile.Close();
            }
           
            static int menu()
            {
                int choice;
                Console.WriteLine("\nWelcom to Eployee page");
                Console.WriteLine("\t1.Enter your information");
                Console.WriteLine("\t2.Show your information");
                Console.WriteLine("\t3.Change to Admin status");
                Console.WriteLine("\t0.Exit the program and go back to start!");
                Console.WriteLine();
                Console.WriteLine("Enter your choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                return choice;
            }
            static void ShowList()
            {
                Console.WriteLine("\nYour information is : ");
                using (var inFile = new StreamReader(filename))
                {
                    string line;
                    int number = 1;
                    while (inFile.Peek() != -1)
                    {
                        line = inFile.ReadLine();
                        Console.Write(number + " ");
                        Console.WriteLine(line);
                        ++number;
                    }
                    Console.WriteLine();
                    inFile.Close();
                }
            }
        }
    }
}