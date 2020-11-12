using SistemaRestaurant.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaRestaurant.Datos
{
   public class Dpermission
    {

        public bool Insert_Permissions(Lpermission parameters)
        {
            try
            {
                Connection.open();
                SqlCommand cmd = new SqlCommand("Insert_Permissions", Connection.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdModule", parameters.IdModule);
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

        public bool Delete_Permissions(Lpermission parameters)
        {
            try
            {
                Connection.open();
                SqlCommand cmd = new SqlCommand("Delete_Permissions", Connection.connect);
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
        public bool Edit_Permissions(Lpermission parameters)
        {
            try
            {
                Connection.open();
                SqlCommand cmd = new SqlCommand("Edit_Permissions", Connection.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPermissions", parameters.IdPermission);
                cmd.Parameters.AddWithValue("@IdModule", parameters.IdModule);
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
        public void show_Permissions(ref DataTable dt, Lpermission parameters)
        {
            try
            {
                Connection.open();
                SqlDataAdapter da = new SqlDataAdapter("show_Permissions", Connection.connect);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@iduser", parameters.IdUser);

                da.Fill(dt);

                Connection.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
