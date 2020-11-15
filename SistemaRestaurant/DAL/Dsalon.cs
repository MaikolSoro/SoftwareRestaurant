using SistemaRestaurant.BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaRestaurant.DAL
{
    public class Dsalon
    {
        public bool insert_Salon(Lsalon parameters)
        {
            try
            {
                Connection.open();
                SqlCommand cmd = new SqlCommand("insert_salon", Connection.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Salon", parameters.Salon);
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

        public void drawSalons(ref DataTable dt)
        {
            try
            {
                Connection.open();
                SqlDataAdapter da = new SqlDataAdapter("show_Salons", Connection.connect);
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
    }
}
