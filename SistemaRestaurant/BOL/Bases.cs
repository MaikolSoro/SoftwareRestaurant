using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;

namespace SistemaRestaurant.BOL
{
    public class Bases
    {

        public void DesignDatagridview(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle Headboard = new DataGridViewCellStyle();
            Headboard.BackColor = Color.White;
            Headboard.ForeColor = Color.Black;
            Headboard.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            List.ColumnHeadersDefaultCellStyle = Headboard;
        }

        public void DesignDatagridviewDelete(ref DataGridView List)
        {
            foreach (DataGridViewRow row in List.Rows)
            {
                string state;
                state = row.Cells["Estado"].Value.ToString();
                if (state == "ELIMINADO")
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Strikeout | FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public static TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
        public static MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

        public static string Encrypt(string text)
        {
            string tempEncrypt = null;
            if (string.IsNullOrEmpty(text.Trim(' ')))
            {
                tempEncrypt = "";
            }
            else
            {
                des.Key = hashmd5.ComputeHash((new UnicodeEncoding()).GetBytes(Decryption.appPwdUnique));
                des.Mode = CipherMode.ECB;
                ICryptoTransform encrypt = des.CreateEncryptor();
                byte[] buff = UnicodeEncoding.ASCII.GetBytes(text);
                tempEncrypt = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length));
            }
            return tempEncrypt;
        }
        public static string Decrypt(string text)
        {
            string tempDecrypt = null;
            if (string.IsNullOrEmpty(text.Trim(' ')))
            {
                tempDecrypt = "";
            }
            else
            {
                des.Key = hashmd5.ComputeHash((new UnicodeEncoding()).GetBytes(Decryption.appPwdUnique));
                des.Mode = CipherMode.ECB;
                ICryptoTransform desencrypta = des.CreateDecryptor();
                byte[] buff = Convert.FromBase64String(text);
                tempDecrypt = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length));
            }
            return tempDecrypt;
        }
    }
}
