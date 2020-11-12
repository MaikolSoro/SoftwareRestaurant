using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Xml;

namespace SistemaRestaurant.Logica
{
    class Decryption
    {

        static private AES aes = new AES();
        static public string CnString;
        private static string dbcnString;
        public static string appPwdUnique = "softwareRestaurant_en_c#_SQLServer.";


        /// <summary>
        /// Desencryptar la conexion de la BD
        /// </summary>
        /// <returns></returns>
        public static object checkServer()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            dbcnString = root.Attributes.Item(0).Value;
            CnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
            return CnString;

        }
        public static object checkServerWEB()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Conexion_web.xml");
            XmlElement root = doc.DocumentElement;
            dbcnString = root.Attributes.Item(0).Value;
            CnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
            return CnString;

        }
    }
}
