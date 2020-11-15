using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaRestaurant.DAL;
namespace SistemaRestaurant.GUI.Tables_salons
{
    public partial class Configure_tables : Form
    {
     
        public Configure_tables()
        {
            InitializeComponent();
        }

        private void drawSalons()
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable dt = new DataTable();
            Dsalon function = new Dsalon();
            function.drawSalons(ref dt);
            foreach (DataRow rdr in dt.Rows)
            {
                Button b = new Button();
                Panel panelC1 = new Panel();
                Panel sidePanel = new Panel();

                b.Text = rdr["Salon"].ToString();
                b.Name = rdr["Id_salon"].ToString();
                b.Tag = rdr["State"].ToString();
                b.Dock = DockStyle.Fill;
                b.BackColor = Color.Transparent;
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                b.FlatAppearance.MouseOverBackColor = Color.FromArgb(43, 43, 43);

                b.TextAlign = ContentAlignment.MiddleLeft;
                b.Tag = rdr["Estado"].ToString();

                panelC1.Size = new System.Drawing.Size(244, 58);
                panelC1.Name = rdr["Id_salon"].ToString();

                sidePanel.Size = new System.Drawing.Size(3, 58);
                sidePanel.Dock = DockStyle.Left;
                sidePanel.BackColor = Color.Transparent;
                sidePanel.Name = rdr["Id_salon"].ToString();
                string state = rdr["Estado"].ToString();

                if (state == "ELIMINADO")
                {
                    b.Text = rdr["Salon"].ToString() + " - Eliminado";
                    b.ForeColor = Color.FromArgb(231, 63, 67);
                }
                else
                {
                    b.ForeColor = Color.White;
                }
                panelC1.Controls.Add(b);
                panelC1.Controls.Add(sidePanel);
                flowLayoutPanel1.Controls.Add(panelC1);

                b.BringToFront();
                sidePanel.SendToBack();


            }
        }
        private void Configurar_mesas_ok_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
         void frm_FormClosed(Object sender, FormClosedEventArgs  e)
        {
          
        }

        private void Configurar_mesas_ok_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
        }
        
        
        private void Button8_Click(object sender, EventArgs e)
        {
        }

        private void Button6_Click(object sender, EventArgs e)
        {
        }
    
        private void Button7_Click(object sender, EventArgs e)
        {
        }
    }
}
