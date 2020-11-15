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
    public class Dtables
    {
        public bool insert_tables(Ltables parameters)
        {
            try
            {
                Connection.open();
                SqlCommand cmd = new SqlCommand("insert_table", Connection.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@table", parameters.Table);
                cmd.Parameters.AddWithValue("@idsalon", parameters.Id_salon);
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
    }
}
