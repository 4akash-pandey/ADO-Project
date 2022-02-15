using System;
using System.Collections.Generic;
using System.Data.SqlClient;

class HallDAO
{
    SqlConnection SqlConnection = DBConnection.GetConnection();

    public bool InsertHall(Hall hall)
    {
        bool flag = false;

        SqlConnection.Open();

        SqlCommand sqlCommand = new SqlCommand("insert into hall (name, mobile_number, cost_per_day, owner) values (@name, @mobile_number, @cost_per_day, @owner)", SqlConnection);

        sqlCommand.Parameters.AddWithValue("@name", hall.Name);
        sqlCommand.Parameters.AddWithValue("@mobile_number", hall.MobileNumber);
        sqlCommand.Parameters.AddWithValue("@cost_per_day", hall.CostPerDay);
        sqlCommand.Parameters.AddWithValue("@owner", hall.Owner);

        int result = sqlCommand.ExecuteNonQuery();

        if (result > 0)
        {
            flag = true;
        }

        SqlConnection.Close();

        return flag;
    }

    public bool UpdateHall(int hallId, double costPerDay)
    {
        bool flag = false;

        SqlConnection.Open();

        SqlCommand sqlCommand = new SqlCommand("update hall set cost_per_day = @cost_per_day where id = @id", SqlConnection);

        sqlCommand.Parameters.AddWithValue("@id", hallId);
        sqlCommand.Parameters.AddWithValue("@cost_per_day", costPerDay);

        int result = sqlCommand.ExecuteNonQuery();

        if (result > 0)
        {
            flag = true;
        }

        SqlConnection.Close();

        return flag;
    }

    public bool DeleteHall(int hallId)
    {
        bool flag = false;

        SqlConnection.Open();

        SqlCommand sqlCommand = new SqlCommand("delete from hall where id = @id", SqlConnection);

        sqlCommand.Parameters.AddWithValue("@id", hallId);

        int result = sqlCommand.ExecuteNonQuery();

        if (result > 0)
        {
            flag = true;
        }

        SqlConnection.Close();

        return flag;
    }

    public List<Hall> GetAllHall()
    {
        List<Hall> list = new List<Hall>();

        SqlConnection.Open();

        SqlCommand sqlCommand = new SqlCommand("select id, name, mobile_number, cost_per_day, owner from hall", SqlConnection);

        SqlDataReader reader = sqlCommand.ExecuteReader();

        while (reader.Read())
        {
            Hall hall = new Hall(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToDouble(reader[3]), Convert.ToString(reader[4]));
            list.Add(hall);
        }

        SqlConnection.Close();

        return list;
    }
}