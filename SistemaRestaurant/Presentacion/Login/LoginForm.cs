using SistemaRestaurant.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaRestaurant.Presentacion.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void drawUsers()
        {
            PanelMostradorUsuarios.Controls.Clear();

            DataTable dt = new DataTable();
            Dusers function = new Dusers();
            function.drawUsers(ref dt);
            foreach (DataRow rdr in dt.Rows)
            {
                Label l = new Label();
                Panel p = new Panel();
                PictureBox Pt = new PictureBox();
                l.Text = rdr["Login"].ToString();
                l.Name = rdr["IdUsuario"].ToString();
                l.Size = new Size(175, 25);
                l.Font = new Font("Microsoft Sans Serif", 13);
                l.BackColor = Color.Transparent;
                l.ForeColor = Color.White;
                l.Dock = DockStyle.Bottom;
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Cursor = Cursors.Hand;

                p.Size = new Size(155, 167);
                p.BorderStyle = BorderStyle.None;
                p.BackColor = Color.FromArgb(20, 20, 20);

                Pt.BackgroundImage = null;
                byte[] bi = (Byte[])rdr["Icono"];
                MemoryStream ms = new MemoryStream(bi);
                Pt.Image = Image.FromStream(ms);
                Pt.Dock = DockStyle.Fill;
                Pt.SizeMode = PictureBoxSizeMode.Zoom;
                Pt.Tag = rdr["Login"].ToString();
                Pt.Cursor = Cursors.Hand;

                p.Controls.Add(l);
                p.Controls.Add(Pt);
                Pt.BringToFront();
                PanelMostradorUsuarios.Controls.Add(p);
                l.Click += L_Click;
                Pt.Click += Pt_Click;

            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
       

        private void Pt_Click(object sender, EventArgs e)
        {
          
        }

        private void L_Click(object sender, EventArgs e)
        {
           


        }
      

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
        }
      
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contraseña erronea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
        }

        private void btn2_Click(object sender, EventArgs e)
        {
        }

        private void btn3_Click(object sender, EventArgs e)
        {
        }

        private void btn4_Click(object sender, EventArgs e)
        {
        }

        private void btn5_Click(object sender, EventArgs e)
        {
        }

        private void btn6_Click(object sender, EventArgs e)
        {
        }

        private void btn7_Click(object sender, EventArgs e)
        {
        }

        private void btn8_Click(object sender, EventArgs e)
        {
        }

        private void btn9_Click(object sender, EventArgs e)
        {
        }

        private void btn0_Click(object sender, EventArgs e)
        {
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
        }

        private void btnborrarderecha_Click(object sender, EventArgs e)
        {

        }
    }
}
