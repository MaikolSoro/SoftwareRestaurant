using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;
using SistemaRestaurant.Datos;
using SistemaRestaurant.Logica;

namespace SistemaRestaurant.Presentacion.Users
{
    public partial class UsuariosOk : Form
    {
        bool proceeds;
        int iduser;
        string state;
        public UsuariosOk()
        {
            InitializeComponent();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            DataTable dt = new DataTable();
            Dusers funcion = new Dusers();
            funcion.search_users(ref dt, txtSearch.Text);
            datalistadoUsers.DataSource = dt;
        }
       
        private void drawModules()
        {
            Dmodule function = new Dmodule();
            DataTable dt = new DataTable();
            function.show_Modules(ref dt);
            datalistadoPermission.DataSource = dt;

        }

        private void clean()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtUser.Clear();
            txtEmail.Clear();
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            clean();
            enablePanels();
            drawModules();
        }
        private void enablePanels()
        {
            panelregistro.Visible = true;
            lblanuncioIcono.Visible = true;
            panelIcono.Visible = false;
            panelregistro.Dock = DockStyle.Fill;
            btnSave.Visible = true;
            btnActualizar.Visible = false;
        }

        private void UsuariosOk_Load(object sender, EventArgs e)
        {
            showUsers();
        }
        private void showUsers()
        {
            DataTable dt = new DataTable();
            Dusers funcion = new Dusers();
            funcion.show_Users(ref dt);
            datalistadoUsers.DataSource = dt;

            //PintarGrid();
        }

        private void cbxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxRol.SelectedIndex;
            foreach (DataGridViewRow row in datalistadoPermission.Rows)
            {
                bool mark = Convert.ToBoolean(row.Cells["Marcar"].Value);
                string Module = row.Cells["Modulo"].Value.ToString();
                if (index== 0)
                {
                    if (Module == "Ventas") { row.Cells[0].Value = true; }
                    if (Module == "Compras") { row.Cells[0].Value = false; }
                    if (Module == "Caja") { row.Cells[0].Value = false; }
                }
                if (index == 1)
                {
                    if (Module == "Ventas") { row.Cells[0].Value = true; }
                    if (Module == "Compras") { row.Cells[0].Value = false; }
                    if (Module == "Caja") { row.Cells[0].Value = true; }
                }
                if (index == 2)
                {
                    row.Cells[0].Value = true;
                }
            }
        }

        private void insertUsers()
        {
            Lusers parameters = new Lusers();
            Dusers function = new Dusers();
            parameters.Name = txtName.Text;
            parameters.Login = txtUser.Text;
            //parameters.Password = Bases.Encriptar(txtPassword.Text);
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parameters.Icon = ms.GetBuffer();
            parameters.Email = txtEmail.Text;
            parameters.Role = cbxRol.Text;
            if (function.InsertUsers(parameters) == true)
            {
                GetUserID();
                insertPermissions();

            }
        }
        private void GetUserID()
        {
            Dusers function = new Dusers();
            function.GetUserID(ref iduser,txtUser.Text);
        }
        private void insertPermissions()
        {
            foreach (DataGridViewRow row in datalistadoPermission.Rows)
            {
                int idModule = Convert.ToInt32(row.Cells["IdModulo"].Value);
                bool marked = Convert.ToBoolean(row.Cells["Marcar"].Value);
                if (marked == true)
                {
                    Lpermission parametros = new Lpermission();
                    Dpermission funcion = new Dpermission();
                    parametros.IdModule = idModule;
                    parametros.IdUser = iduser;
                    if (funcion.Insert_Permissions(parametros) == true)
                    {
                        showUsers();
                        panelregistro.Visible = false;
                    }
                }
            }


        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private void AgregarIcono_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de imagenes";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Icono.BackgroundImage = null;
                Icono.Image = new Bitmap(dlg.FileName);
                hidePanelIcons();
            }
        }
        private void hidePanelIcons()
        {
            panelIcono.Visible = false;
            lblanuncioIcono.Visible = false;
            Icono.Visible = true;
        }

        private void lblanuncioIcono_Click(object sender, EventArgs e)
        {
            panelIcono.Visible = true;
            panelIcono.Dock = DockStyle.Fill;
            panelIcono.BringToFront();
        }

        private void p8_Click(object sender, EventArgs e)
        {
            Icono.Image = p8.Image;
            hidePanelIcons();
        }

        private void p7_Click(object sender, EventArgs e)
        {
            Icono.Image = p7.Image;
            hidePanelIcons();
        }

        private void p6_Click(object sender, EventArgs e)
        {
            Icono.Image = p6.Image;
            hidePanelIcons();
        }

        private void p5_Click(object sender, EventArgs e)
        {
            Icono.Image = p5.Image;
            hidePanelIcons();
        }

        private void p4_Click(object sender, EventArgs e)
        {
            Icono.Image = p4.Image;
            hidePanelIcons();
        }

        private void p3_Click(object sender, EventArgs e)
        {
            Icono.Image = p3.Image;
            hidePanelIcons();
        }

        private void p2_Click(object sender, EventArgs e)
        {
            Icono.Image = p2.Image;
            hidePanelIcons();
        }

        private void p1_Click(object sender, EventArgs e)
        {
            Icono.Image = p6.Image;
            hidePanelIcons();

        }

        private void btnVolverIcono_Click(object sender, EventArgs e)
        {
            hidePanelIcons();
        }

        private void datalistadoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
     
       
      
        private void btnvolver_Click(object sender, EventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
           else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
           else
            {
                e.Handled = true;
            }
        }

       
    }
}
