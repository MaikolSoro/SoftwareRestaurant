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
using SistemaRestaurant.DAL;
using SistemaRestaurant.BOL;

namespace SistemaRestaurant.GUI.Users
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
            PaintGrid();
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

            PaintGrid();
        }
        private void PaintGrid()
        {
            Bases property = new Bases();
            property.DesignDatagridview(ref datalistadoUsers);
            property.DesignDatagridviewDelete(ref datalistadoUsers);
            datalistadoUsers.Columns[2].Visible = false;
            datalistadoUsers.Columns[6].Visible = false;
            datalistadoUsers.Columns[7].Visible = false;

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
            parameters.Password = Bases.Encrypt(txtPassword.Text);
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
        private void Validations()
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                if (!string.IsNullOrEmpty(txtUser.Text))
                {
                    if (!string.IsNullOrEmpty(txtPassword.Text))
                    {
                        if (!string.IsNullOrEmpty(cbxRol.Text))
                        {
                            if (lblanuncioIcono.Visible == false)
                            {
                                proceeds = true;
                                if (!string.IsNullOrEmpty(txtEmail.Text)) { txtEmail.Text = "-"; }

                            }
                            else
                            {
                                MessageBox.Show("Seleccione un Icono");
                                proceeds = false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Seleccione un rol");
                            proceeds = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la contraseña");
                        proceeds = false;

                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Usuario");
                    proceeds = false;

                }
            }
            else
            {
                proceeds = false;
                MessageBox.Show("Ingrese el Nombre");
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
            Validations();
            if (proceeds == true)
            {
                insertUsers();
            }
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
        private void datalistadoUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistadoUsers.Columns["Editar"].Index)
            {
                getStatus();
                if (state == "ELIMINADO")
                {
                    DialogResult resultado = MessageBox.Show("Este Usuario se Elimino. ¿Desea Volver a Habilitarlo?", "Restauracion de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        //   restaurar();
                        restore();
                    }
                }
                else
                {
                    getData();
                }

            }
            if (e.ColumnIndex == datalistadoUsers.Columns["Eliminar"].Index)
            {
                DialogResult resultado = MessageBox.Show("¿Realmente desea eliminar este Registro?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {

                    //eliminarUsuarios();
                    deleteUsers();
                }
            }
        }
        private void getStatus()
        {
            state = datalistadoUsers.SelectedCells[9].Value.ToString();
        }
        private void getData()
        {
            txtName.Text = datalistadoUsers.SelectedCells[3].Value.ToString();
            txtUser.Text = datalistadoUsers.SelectedCells[4].Value.ToString();
            txtPassword.Text = Bases.Decrypt(datalistadoUsers.SelectedCells[5].Value.ToString());
            Icono.BackgroundImage = null;
            byte[] b = (byte[])(datalistadoUsers.SelectedCells[6].Value);
            MemoryStream ms = new MemoryStream(b);
            Icono.Image = Image.FromStream(ms);
            txtEmail.Text = datalistadoUsers.SelectedCells[7].Value.ToString();
            cbxRol.Text = datalistadoUsers.SelectedCells[8].Value.ToString();

            panelregistro.Visible = true;
            panelregistro.Dock = DockStyle.Fill;
            lblanuncioIcono.Visible = false;
            btnActualizar.Visible = true;
            btnSave.Visible = false;
            drawModules();
            showPermissions();
            
        }
        private void deleteUsers()
        {
            captureUserId();
            Lusers parametros = new Lusers();
            Dusers funcion = new Dusers();
            parametros.IdUser = iduser;
            if (funcion.delete_Users(parametros) == true)
            {
                showUsers();
            }
        }
        private void restore()
        {
            captureUserId();
            Lusers parameters = new Lusers();
            Dusers function = new Dusers();
            parameters.IdUser = iduser;
            if (function.restore_user(parameters) == true)
            {
                showUsers();
            }
        }
        private void captureUserId()
        {
            iduser = Convert.ToInt32(datalistadoUsers.SelectedCells[2].Value);
        }
        private void showPermissions()
        {
            DataTable dt = new DataTable();
            Dpermission funcion = new Dpermission();
            Lpermission parametros = new Lpermission();
            parametros.IdUser = iduser;
            funcion.show_Permissions(ref dt, parametros);

            foreach (DataRow rowPermissions in dt.Rows)
            {
                int idmoduloPermisos = Convert.ToInt32(rowPermissions["IdModulo"]);
                foreach (DataGridViewRow rowModulos in datalistadoPermission.Rows)
                {
                    int idmodulo = Convert.ToInt32(rowModulos.Cells["IdModulo"].Value);
                    if (idmoduloPermisos == idmodulo)
                    {
                        rowModulos.Cells[0].Value = true;
                    }
                }
            }

        }
        private void btnvolver_Click(object sender, EventArgs e)
        {
            panelregistro.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Validations();
            if (proceeds == true)
            {
                editUser();
            }
        }
        private void editUser()
        {
            Lusers parameters = new Lusers();
            Dusers funcion = new Dusers();
            parameters.IdUser = iduser;
            parameters.Name = txtName.Text;
            parameters.Login = txtUser.Text;
            parameters.Password = Bases.Encrypt(txtPassword.Text);
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parameters.Icon = ms.GetBuffer();
            parameters.Email = txtEmail.Text;
            parameters.Role = cbxRol.Text;
            if (funcion.edit_Users(parameters) == true)
            {
                removePermissions();
                insertPermissions();
            }
        }
        private void removePermissions()
        {
            Lpermission parameters = new Lpermission();
            Dpermission funcion = new Dpermission();
            parameters.IdUser = iduser;
            funcion.Delete_Permissions(parameters);


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
