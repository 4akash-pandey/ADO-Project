using System;
using System.Collections.Generic;

class HallBO
{
    public bool InsertHall(Hall hall)
    {
        return new HallDAO().InsertHall(hall);
    }

    public bool UpdateHall(int hallId, double costPerDay)
    {
        return new HallDAO().UpdateHall(hallId, costPerDay);
    }

    public bool DeleteHall(int hallId)
    {
        return new HallDAO().DeleteHall(hallId);
    }

    public void DisplayHalls()
    {
        List<Hall> halls = new List<Hall>();

        HallDAO hallDAO = new HallDAO();

        halls = hallDAO.GetAllHall();

        if (halls == null)
        {
            Console.WriteLine("No hall available");
        }
        else
        {
            Console.WriteLine(String.Format("{0,-5} {1,-20} {2,-15} {3,-10} {4}", "Id", "Name", "Mobile number", "Cost per day", "Owner"));

            foreach (Hall item in halls)
            {
                Console.WriteLine(String.Format("{0,-5} {1,-20} {2,-15} {3,-10} {4}", item.Id, item.Name, item.MobileNumber, item.CostPerDay, item.Owner));
            }
        }       
    }
}