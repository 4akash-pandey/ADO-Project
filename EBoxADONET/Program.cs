using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int choice;
        HallBO bo = new HallBO();
        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Insert hall");
            Console.WriteLine("2.Update cost per day");
            Console.WriteLine("3.Delete hall");
            Console.WriteLine("4.Exit");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the hall name");
                    string hName = Console.ReadLine();
                    Console.WriteLine("Enter the mobile number");
                    string hMobileNumber = Console.ReadLine();
                    Console.WriteLine("Enter the cost per day");
                    double hCostPerDay = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the owner name");
                    string hOwner = Console.ReadLine();

                    Hall hall = new Hall(hName, hMobileNumber, hCostPerDay, hOwner);

                    if (bo.InsertHall(hall))
                    {
                        Console.WriteLine("Hall inserted successfully");
                        bo.DisplayHalls();
                    }
                    break;

                case 2:
                    Console.WriteLine("Enter the hall id");
                    int hallId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the cost per day");
                    double costPerDay = Convert.ToDouble(Console.ReadLine());

                    if (bo.UpdateHall(hallId, costPerDay))
                    {
                        Console.WriteLine("Hall updated successfully");
                    }
                    else
                    {
                        Console.WriteLine("Invalid hall id");
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter the hall id");
                    int deleteId = Convert.ToInt32(Console.ReadLine());

                    if (bo.DeleteHall(deleteId))
                    {
                        Console.WriteLine("Hall deleted successfully");
                    }
                    else
                    {
                        Console.WriteLine("Invalid hall id");
                    }
                    break;

                case 4:
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        } while (choice > 0 && choice < 4);
    }
}