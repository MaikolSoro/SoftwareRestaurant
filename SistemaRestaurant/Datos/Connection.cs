using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
namespace SistemaRestaurant.Datos
{
    class Connection
    {

        public static string connection = Convert.ToString(Logica.Decryption.checkServer());
        public static SqlConnection connect = new SqlConnection(connection);

        public static void open()
        {

            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public static void cerrar()
        {
            if(connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}
