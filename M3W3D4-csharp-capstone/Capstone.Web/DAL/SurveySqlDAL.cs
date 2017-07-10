using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;
using System.Data.SqlClient;

namespace Capstone.Web.DAL
{
    public class SurveySqlDAL
    {
        private string connectionString;


        public SurveySqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<SurveyModel> GetAllPosts()
        {
            List<SurveyModel> output = new List<SurveyModel>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select count(parkCode) as total, ParkCode from[NationalParkGeek].[dbo].[survey_result] group by ParkCode order by total desc;", connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        SurveyModel s = new SurveyModel();
                        s.FavoritePark = Convert.ToString(reader["parkCode"]);
                        s.Total = Convert.ToInt32(reader["total"]);
                        output.Add(s);
                    }
                }
            }
            catch (SqlException e)
            {
                throw;
            }
            return output;

        }

        public bool SaveNewPost(SurveyModel post)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO survey_result VALUES(@parkCode, @emailAddress, @state, @activityLevel);" + "SELECT SCOPE_IDENTITY();", conn);
                    
                    cmd.Parameters.AddWithValue("@parkCode", post.FavoritePark);
                    cmd.Parameters.AddWithValue("@emailAddress", post.Email);
                    cmd.Parameters.AddWithValue("@state", post.Residence);
                    cmd.Parameters.AddWithValue("@activityLevel", post.ActivityLevel);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected >= 0;
                    
                }
            }
            catch (SqlException ex)
            {
                // Error Logging that a problem occurred, don't show the user
               throw;
            }
            
        }
    }
}