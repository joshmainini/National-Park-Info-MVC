using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;
using System.Data.SqlClient;

namespace Capstone.Web.DAL
{
    public class ParkSqlDAL
    {
        private string connectionString;

        public ParkSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public Parks GetPark(string id)
        {

            Parks pk = new Parks();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM park WHERE parkCode = @park_id AND parkCode IS NOT NULL;", connection);
                    cmd.Parameters.AddWithValue("@park_id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Parks pr = new Parks();
                        pr.ParkCode = Convert.ToString(reader["parkCode"]);
                        pr.State = Convert.ToString(reader["state"]);
                        pr.Name = Convert.ToString(reader["parkName"]);
                        pr.Acres = Convert.ToInt32(reader["acreage"]);
                        pr.Elevation = Convert.ToInt32(reader["elevationInFeet"]);
                        pr.TrailMiles = Convert.ToDouble(reader["milesOfTrail"]);
                        pr.NumCampSites = Convert.ToInt32(reader["numberOfCampsites"]);
                        pr.Climate = Convert.ToString(reader["climate"]);
                        pr.YearFounded = Convert.ToInt32(reader["yearFounded"]);
                        pr.AnnualVisitors = Convert.ToInt32(reader["annualVisitorCount"]);
                        pr.Quote = Convert.ToString(reader["inspirationalQuote"]);
                        pr.QuoteAuthor = Convert.ToString(reader["inspirationalQuoteSource"]);
                        pr.Description = Convert.ToString(reader["parkDescription"]);
                        pr.EntryFee = Convert.ToInt32(reader["entryFee"]);
                        pr.AnimalSpecies = Convert.ToInt32(reader["numberOfAnimalSpecies"]);

                        pk = pr;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Unable to retrieve park data, please try again at a later time.");
            }
            return pk;
        }

        public List<Parks> GetAllParks()
        {

            List<Parks> parks = new List<Parks>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM park ORDER BY parkName ASC", conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Parks p = new Parks();
                        p.ParkCode = Convert.ToString(reader["parkCode"]);
                        p.State = Convert.ToString(reader["state"]);
                        p.Name = Convert.ToString(reader["parkName"]);
                        p.Acres = Convert.ToInt32(reader["acreage"]);
                        p.Elevation= Convert.ToInt32(reader["elevationInFeet"]);
                        p.TrailMiles = Convert.ToDouble(reader["milesOfTrail"]);
                        p.NumCampSites = Convert.ToInt32(reader["numberOfCampsites"]);
                        p.Climate = Convert.ToString(reader["climate"]);
                        p.YearFounded = Convert.ToInt32(reader["yearFounded"]);
                        p.AnnualVisitors = Convert.ToInt32(reader["annualVisitorCount"]);
                        p.Quote = Convert.ToString(reader["inspirationalQuote"]);
                        p.QuoteAuthor = Convert.ToString(reader["inspirationalQuoteSource"]);
                        p.Description = Convert.ToString(reader["parkDescription"]);
                        p.EntryFee = Convert.ToInt32(reader["entryFee"]);
                        p.AnimalSpecies = Convert.ToInt32(reader["numberOfAnimalSpecies"]);

                        parks.Add(p);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Unable to retrieve park data, please try again at a later time.");
            }
            return parks;
        }
    }
}