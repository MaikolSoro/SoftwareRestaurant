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
   public class Dmodule
    {
        public bool Insert_Modules(Lmodules parameters)
        {
            try
            {
                Connection.open();
                SqlCommand cmd = new SqlCommand("Insert_Modules", Connection.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Module", parameters.Module);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                Connection.close();
            }
        }
        public bool Edit_Modules(Lmodules parameters)
        {
            try
            {
                Connection.open();
                SqlCommand cmd = new SqlCommand("Edit_Modules", Connection.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdModule", parameters.IdModule);
                cmd.Parameters.AddWithValue("@Module", parameters.Module);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                Connection.close();
            }
        }
        public bool Delete_Modules(Lmodules parameters)
        {
            try
            {
                Connection.open();
                SqlCommand cmd = new SqlCommand("Delete_Modules", Connection.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdModule", parameters.IdModule);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                Connection.close();
            }
        }
        public void show_Modules(ref DataTable dt)
        {
            try
            {
                Connection.open();
                SqlDataAdapter da = new SqlDataAdapter("show_Modules", Connection.connect);
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
