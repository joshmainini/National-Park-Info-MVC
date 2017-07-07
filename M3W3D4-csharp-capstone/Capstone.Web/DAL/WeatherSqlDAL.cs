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
        public List<Weather> GetWeather(string id)
        {

            List<Weather> output = new List<Weather>();

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
                        w.Forecast = Convert.ToString(reader["forecast"]);
                        w.ForcastValue = Convert.ToInt32(reader["fiveDayForecastValue"]);
                        w.LowTemp = Convert.ToDouble(reader["low"]);
                        w.HighTemp = Convert.ToDouble(reader["high"]);

                        output.Add(w);
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