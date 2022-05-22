using System;
using DataStructureProblem;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("welcome to the program");
        DataStructureProblem.LinkedList<int> list = new DataStructureProblem.LinkedList<int>();
        bool check = true;
        Console.WriteLine("1.press 1 to display add data\n2.press 2 to dislpay sorted list.");
        while (check)
        {
            Console.WriteLine("enter the above option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Added data");
                    list.AddNode(56);
                    list.AddNode(30);
                    list.AddNode(40);
                    list.AddNode(70);
                    // list.DisplaySortedList();
                    break;
                case 2:
                    Console.WriteLine("sorted element");
                    list.SortOrderList();
                    break;

                case 0:
                    check = false;
                    break;
            }
        }
    }
}