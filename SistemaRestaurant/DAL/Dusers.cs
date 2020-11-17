using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SistemaRestaurant.BOL;
using System.Windows.Forms;

namespace SistemaRestaurant.DAL
{
    class Dusers
    {
        public bool InsertUsers(Lusers parameters)
        {
			try
			{
				Connection.open();
				SqlCommand cmd = new SqlCommand("insert_Users", Connection.connect);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Name", parameters.Name);
				cmd.Parameters.AddWithValue("@Login", parameters.Login);
				cmd.Parameters.AddWithValue("@Password", parameters.Password);
				cmd.Parameters.AddWithValue("@Icon", parameters.Icon);
				cmd.Parameters.AddWithValue("@Email", parameters.Email);
				cmd.Parameters.AddWithValue("@Role", parameters.Role);
				cmd.Parameters.AddWithValue("@State", "ACTIVO");
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
			finally
			{
				Connection.close();
			}
		}
		public bool edit_Users(Lusers parameters)
		{
			try
			{
				Connection.open();
				SqlCommand cmd = new SqlCommand("edit_Users", Connection.connect);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IdUser", parameters.IdUser);
				cmd.Parameters.AddWithValue("@Name", parameters.Name);
				cmd.Parameters.AddWithValue("@Login", parameters.Login);
				cmd.Parameters.AddWithValue("@Password", parameters.Password);
				cmd.Parameters.AddWithValue("@Icon", parameters.Icon);
				cmd.Parameters.AddWithValue("@Email", parameters.Email);
				cmd.Parameters.AddWithValue("@Role", parameters.Role);

				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
			finally
			{
				Connection.close();
			}

		}
		public bool delete_Users(Lusers parameters)
		{
			try
			{
				Connection.open();
				SqlCommand cmd = new SqlCommand("delete_Users", Connection.connect);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@IdUser", parameters.IdUser);

				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
			finally
			{
				Connection.close();
			}

		}
		public void search_users(ref DataTable dt, string seeker)
		{
			try
			{
				Connection.open();
				SqlDataAdapter da = new SqlDataAdapter("search_users", Connection.connect);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@seeker", seeker);
				da.Fill(dt);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.StackTrace);
			}
			finally
			{
				Connection.close();
			}
		}
		public void show_Users(ref DataTable dt)
		{
			try
			{
				Connection.open();
				SqlDataAdapter da = new SqlDataAdapter("show_Users", Connection.connect);
				da.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
			}
			finally
			{
				Connection.close();
			}
		}

		public void GetUserID(ref int iduser, string Login)
		{
			try
			{
				Connection.open();
				SqlCommand da = new SqlCommand("GetUserID", Connection.connect);
				da.CommandType = CommandType.StoredProcedure;
				da.Parameters.AddWithValue("@Login", Login);
				iduser = Convert.ToInt32(da.ExecuteScalar());
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.StackTrace);
			}
			finally
			{
				Connection.close();
			}
		}

		public bool restore_user(Lusers parameters)
		{
			try
			{
				Connection.open();
				SqlCommand cmd = new SqlCommand("restore_user", Connection.connect);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@iduser", parameters.IdUser);

				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
			finally
			{
				Connection.close();
			}

		}
		public void drawUsers(ref DataTable dt)
		{
			try
			{
				Connection.open();
				SqlDataAdapter da = new SqlDataAdapter("Select * from Usuarios where Estado='ACTIVO'", Connection.connect);
				da.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
			}
			finally
			{
				Connection.close();
			}
		}
		public void validateUser(Lusers parameters, ref int id)
		{
			try
			{
				Connection.open();
				SqlCommand cmd = new SqlCommand("validateUser", Connection.connect);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@password", parameters.Password);
				cmd.Parameters.AddWithValue("@login", parameters.Login);
				id = Convert.ToInt32(cmd.ExecuteScalar());


			}
			catch (Exception ex)
			{
				id = 0;

			}
			finally
			{
				Connection.close();
			}
		}

	}
}
