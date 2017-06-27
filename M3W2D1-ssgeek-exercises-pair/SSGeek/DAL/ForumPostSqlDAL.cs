using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;

namespace SSGeek.DAL
{
	public class ForumPostSqlDAL : IForumPostDAL
	{
		private string connectionString;


		public ForumPostSqlDAL(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public List<ForumPost> GetAllPosts()
		{
			List<ForumPost> output = new List<ForumPost>();

			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand("SELECT * FROM forum_post", connection);
					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						ForumPost f = new ForumPost();
						f.Id = Convert.ToInt32(reader["id"]);
						f.Message = Convert.ToString(reader["message"]);
						f.Username = Convert.ToString(reader["username"]);
						f.Subject = Convert.ToString(reader["subject"]);
						f.PostDate = Convert.ToDateTime(reader["post_date"]);
						output.Add(f);
					}
				}
			}
			catch(SqlException e)
			{
				throw;
			}
			return output;

		}

		public bool SaveNewPost(ForumPost post)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					SqlCommand cmd = new SqlCommand("INSERT INTO forum_post VALUES(@userName, @subject, @message, @post_Date)", conn);

					cmd.Parameters.AddWithValue("@userName", post.Username);
					cmd.Parameters.AddWithValue("@subject", post.Subject);
					cmd.Parameters.AddWithValue("@message", post.Message);
					cmd.Parameters.AddWithValue("@post_Date", DateTime.UtcNow);

					int rowsAffected = cmd.ExecuteNonQuery();

					return (rowsAffected > 0);
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