using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;
using System.Data.SqlClient;

namespace Capstone.Web.DAL
{
    public class WeatherSqlDAL
    {
        private string connectionString;

        public WeatherSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public Weather GetWeather(string id)
        {

            Weather output = new Weather();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM weather WHERE parkCode = @park_id AND parkCode IS NOT NULL;", connection);
                    cmd.Parameters.AddWithValue("@park_id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Weather w = new Weather();
                        w.ParkCode = Convert.ToString(reader["parkCode"]);
                        w.Forecast.Add(Convert.ToString(reader["forecast"]));
                        w.ForcastValue.Add(Convert.ToInt32(reader["fiveDayForecastValue"]));
                        w.LowTemp.Add(Convert.ToInt32(reader["low"]));
                        w.HighTemp.Add(Convert.ToInt32(reader["high"]));

                        output = w;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Unable to retrieve park data, please try again at a later time.");
            }
            return output;
        }
    }
}