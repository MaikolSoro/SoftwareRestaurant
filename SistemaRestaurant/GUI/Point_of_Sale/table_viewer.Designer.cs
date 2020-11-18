namespace SistemaRestaurant.GUI.Point_of_Sale
{
    partial class Table_viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table_viewer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelBienvienida = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.PanelMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelSalones = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panelbotones = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DATALISTADO_PRODUCTOS_OKA_libre = new System.Windows.Forms.DataGridView();
            this.DataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DATALISTADO_PRODUCTOS_OKA = new System.Windows.Forms.DataGridView();
            this.DataGridViewCheckBoxColumn9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.PanelUNIONMesas = new System.Windows.Forms.Panel();
            this.txtpaso = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelHerramientas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnadministrar = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelBienvienida.SuspendLayout();
            this.PanelSalones.SuspendLayout();
            this.Panelbotones.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATALISTADO_PRODUCTOS_OKA_libre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATALISTADO_PRODUCTOS_OKA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.PanelUNIONMesas.SuspendLayout();
            this.PanelHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelHerramientas);
            this.panel1.Controls.Add(this.PanelMesas);
            this.panel1.Controls.Add(this.PanelBienvienida);
            this.panel1.Controls.Add(this.PanelSalones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 749);
            this.panel1.TabIndex = 0;
            // 
            // PanelBienvienida
            // 
            this.PanelBienvienida.BackColor = System.Drawing.Color.Black;
            this.PanelBienvienida.Controls.Add(this.Label3);
            this.PanelBienvienida.Location = new System.Drawing.Point(366, 55);
            this.PanelBienvienida.Name = "PanelBienvienida";
            this.PanelBienvienida.Size = new System.Drawing.Size(396, 145);
            this.PanelBienvienida.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.DimGray;
            this.Label3.Location = new System.Drawing.Point(0, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(396, 145);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Elija un Salon Para Iniciar ";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMesas
            // 
            this.PanelMesas.BackColor = System.Drawing.Color.Black;
            this.PanelMesas.Location = new System.Drawing.Point(333, 206);
            this.PanelMesas.Name = "PanelMesas";
            this.PanelMesas.Size = new System.Drawing.Size(396, 134);
            this.PanelMesas.TabIndex = 5;
            this.PanelMesas.Visible = false;
            // 
            // PanelSalones
            // 
            this.PanelSalones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PanelSalones.Controls.Add(this.FlowLayoutPanel1);
            this.PanelSalones.Controls.Add(this.Panelbotones);
            this.PanelSalones.Controls.Add(this.PanelUNIONMesas);
            this.PanelSalones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSalones.Location = new System.Drawing.Point(0, 0);
            this.PanelSalones.Name = "PanelSalones";
            this.PanelSalones.Size = new System.Drawing.Size(279, 749);
            this.PanelSalones.TabIndex = 4;
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.AutoScroll = true;
            this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(279, 418);
            this.FlowLayoutPanel1.TabIndex = 0;
            // 
            // Panelbotones
            // 
            this.Panelbotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Panelbotones.Controls.Add(this.btnHerramientas);
            this.Panelbotones.Controls.Add(this.button8);
            this.Panelbotones.Controls.Add(this.button5);
            this.Panelbotones.Controls.Add(this.button6);
            this.Panelbotones.Controls.Add(this.panel2);
            this.Panelbotones.Controls.Add(this.button4);
            this.Panelbotones.Controls.Add(this.button1);
            this.Panelbotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panelbotones.Location = new System.Drawing.Point(0, 418);
            this.Panelbotones.Name = "Panelbotones";
            this.Panelbotones.Size = new System.Drawing.Size(279, 331);
            this.Panelbotones.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.DATALISTADO_PRODUCTOS_OKA_libre);
            this.panel2.Controls.Add(this.DATALISTADO_PRODUCTOS_OKA);
            this.panel2.Controls.Add(this.ComboBox1);
            this.panel2.Controls.Add(this.Button2);
            this.panel2.Controls.Add(this.TextBox2);
            this.panel2.Controls.Add(this.DataGridView1);
            this.panel2.Controls.Add(this.TextBox1);
            this.panel2.Location = new System.Drawing.Point(253, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 10);
            this.panel2.TabIndex = 498;
            // 
            // DATALISTADO_PRODUCTOS_OKA_libre
            // 
            this.DATALISTADO_PRODUCTOS_OKA_libre.AllowUserToAddRows = false;
            this.DATALISTADO_PRODUCTOS_OKA_libre.AllowUserToDeleteRows = false;
            this.DATALISTADO_PRODUCTOS_OKA_libre.AllowUserToResizeRows = false;
            this.DATALISTADO_PRODUCTOS_OKA_libre.BackgroundColor = System.Drawing.Color.White;
            this.DATALISTADO_PRODUCTOS_OKA_libre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DATALISTADO_PRODUCTOS_OKA_libre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATALISTADO_PRODUCTOS_OKA_libre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckBoxColumn2});
            this.DATALISTADO_PRODUCTOS_OKA_libre.EnableHeadersVisualStyles = false;
            this.DATALISTADO_PRODUCTOS_OKA_libre.Location = new System.Drawing.Point(18, 30);
            this.DATALISTADO_PRODUCTOS_OKA_libre.Name = "DATALISTADO_PRODUCTOS_OKA_libre";
            this.DATALISTADO_PRODUCTOS_OKA_libre.ReadOnly = true;
            this.DATALISTADO_PRODUCTOS_OKA_libre.RowHeadersVisible = false;
            this.DATALISTADO_PRODUCTOS_OKA_libre.RowHeadersWidth = 9;
            this.DATALISTADO_PRODUCTOS_OKA_libre.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DATALISTADO_PRODUCTOS_OKA_libre.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DATALISTADO_PRODUCTOS_OKA_libre.RowTemplate.Height = 40;
            this.DATALISTADO_PRODUCTOS_OKA_libre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATALISTADO_PRODUCTOS_OKA_libre.Size = new System.Drawing.Size(165, 173);
            this.DATALISTADO_PRODUCTOS_OKA_libre.TabIndex = 495;
            // 
            // DataGridViewCheckBoxColumn2
            // 
            this.DataGridViewCheckBoxColumn2.DataPropertyName = "Marcar";
            this.DataGridViewCheckBoxColumn2.HeaderText = "Marcar";
            this.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2";
            this.DataGridViewCheckBoxColumn2.ReadOnly = true;
            this.DataGridViewCheckBoxColumn2.Visible = false;
            // 
            // DATALISTADO_PRODUCTOS_OKA
            // 
            this.DATALISTADO_PRODUCTOS_OKA.AllowUserToAddRows = false;
            this.DATALISTADO_PRODUCTOS_OKA.AllowUserToDeleteRows = false;
            this.DATALISTADO_PRODUCTOS_OKA.AllowUserToResizeRows = false;
            this.DATALISTADO_PRODUCTOS_OKA.BackgroundColor = System.Drawing.Color.White;
            this.DATALISTADO_PRODUCTOS_OKA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DATALISTADO_PRODUCTOS_OKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATALISTADO_PRODUCTOS_OKA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckBoxColumn9});
            this.DATALISTADO_PRODUCTOS_OKA.EnableHeadersVisualStyles = false;
            this.DATALISTADO_PRODUCTOS_OKA.Location = new System.Drawing.Point(-55, 30);
            this.DATALISTADO_PRODUCTOS_OKA.Name = "DATALISTADO_PRODUCTOS_OKA";
            this.DATALISTADO_PRODUCTOS_OKA.ReadOnly = true;
            this.DATALISTADO_PRODUCTOS_OKA.RowHeadersVisible = false;
            this.DATALISTADO_PRODUCTOS_OKA.RowHeadersWidth = 9;
            this.DATALISTADO_PRODUCTOS_OKA.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DATALISTADO_PRODUCTOS_OKA.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DATALISTADO_PRODUCTOS_OKA.RowTemplate.Height = 40;
            this.DATALISTADO_PRODUCTOS_OKA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATALISTADO_PRODUCTOS_OKA.Size = new System.Drawing.Size(165, 173);
            this.DATALISTADO_PRODUCTOS_OKA.TabIndex = 495;
            // 
            // DataGridViewCheckBoxColumn9
            // 
            this.DataGridViewCheckBoxColumn9.DataPropertyName = "Marcar";
            this.DataGridViewCheckBoxColumn9.HeaderText = "Marcar";
            this.DataGridViewCheckBoxColumn9.Name = "DataGridViewCheckBoxColumn9";
            this.DataGridViewCheckBoxColumn9.ReadOnly = true;
            this.DataGridViewCheckBoxColumn9.Visible = false;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(33, 47);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(124, 21);
            this.ComboBox1.TabIndex = 497;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(18, 30);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(127, 72);
            this.Button2.TabIndex = 8;
            this.Button2.Text = "Button2";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(3, 30);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(110, 22);
            this.TextBox2.TabIndex = 496;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckBoxColumn1});
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Location = new System.Drawing.Point(18, 30);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 9;
            this.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView1.RowTemplate.Height = 40;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(70, 103);
            this.DataGridView1.TabIndex = 495;
            // 
            // DataGridViewCheckBoxColumn1
            // 
            this.DataGridViewCheckBoxColumn1.DataPropertyName = "Marcar";
            this.DataGridViewCheckBoxColumn1.HeaderText = "Marcar";
            this.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            this.DataGridViewCheckBoxColumn1.ReadOnly = true;
            this.DataGridViewCheckBoxColumn1.Visible = false;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(0, 47);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(110, 22);
            this.TextBox1.TabIndex = 496;
            // 
            // PanelUNIONMesas
            // 
            this.PanelUNIONMesas.BackColor = System.Drawing.Color.Black;
            this.PanelUNIONMesas.Controls.Add(this.txtpaso);
            this.PanelUNIONMesas.Controls.Add(this.Label1);
            this.PanelUNIONMesas.Controls.Add(this.Button3);
            this.PanelUNIONMesas.Controls.Add(this.panel3);
            this.PanelUNIONMesas.Location = new System.Drawing.Point(17, 22);
            this.PanelUNIONMesas.Name = "PanelUNIONMesas";
            this.PanelUNIONMesas.Size = new System.Drawing.Size(262, 271);
            this.PanelUNIONMesas.TabIndex = 3;
            // 
            // txtpaso
            // 
            this.txtpaso.AutoSize = true;
            this.txtpaso.ForeColor = System.Drawing.Color.White;
            this.txtpaso.Location = new System.Drawing.Point(44, 62);
            this.txtpaso.Name = "txtpaso";
            this.txtpaso.Size = new System.Drawing.Size(45, 13);
            this.txtpaso.TabIndex = 500;
            this.txtpaso.Text = "txtpaso";
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(262, 126);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "PASO 1 \r\n\r\nSeleccione una mesa de Origen";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 70);
            this.panel3.TabIndex = 9;
            // 
            // PanelHerramientas
            // 
            this.PanelHerramientas.BackColor = System.Drawing.Color.Black;
            this.PanelHerramientas.Controls.Add(this.btnadministrar);
            this.PanelHerramientas.Controls.Add(this.button10);
            this.PanelHerramientas.Controls.Add(this.button11);
            this.PanelHerramientas.Controls.Add(this.button12);
            this.PanelHerramientas.Controls.Add(this.button13);
            this.PanelHerramientas.Controls.Add(this.button14);
            this.PanelHerramientas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PanelHerramientas.Location = new System.Drawing.Point(338, 356);
            this.PanelHerramientas.Name = "PanelHerramientas";
            this.PanelHerramientas.Size = new System.Drawing.Size(807, 92);
            this.PanelHerramientas.TabIndex = 499;
            this.PanelHerramientas.Visible = false;
            // 
            // btnadministrar
            // 
            this.btnadministrar.BackColor = System.Drawing.Color.Transparent;
            this.btnadministrar.BackgroundImage = global::SistemaRestaurant.Properties.Resources.azul;
            this.btnadministrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadministrar.FlatAppearance.BorderSize = 0;
            this.btnadministrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnadministrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnadministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadministrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadministrar.ForeColor = System.Drawing.Color.White;
            this.btnadministrar.Location = new System.Drawing.Point(3, 3);
            this.btnadministrar.Name = "btnadministrar";
            this.btnadministrar.Size = new System.Drawing.Size(125, 84);
            this.btnadministrar.TabIndex = 505;
            this.btnadministrar.Text = "Adminstrar";
            this.btnadministrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadministrar.UseVisualStyleBackColor = false;
            this.btnadministrar.Click += new System.EventHandler(this.btnadministrar_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImage = global::SistemaRestaurant.Properties.Resources.azul;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(134, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(125, 84);
            this.button10.TabIndex = 506;
            this.button10.Text = "Cocina";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImage = global::SistemaRestaurant.Properties.Resources.Rojo;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(265, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(125, 84);
            this.button11.TabIndex = 507;
            this.button11.Text = "Cerrar Todo";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.BackgroundImage = global::SistemaRestaurant.Properties.Resources.azul;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(396, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(125, 84);
            this.button12.TabIndex = 508;
            this.button12.Text = "Cerrar Caja";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.BackgroundImage = global::SistemaRestaurant.Properties.Resources.azul;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(527, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(125, 84);
            this.button13.TabIndex = 509;
            this.button13.Text = "Ver ultima venta";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.BackgroundImage = global::SistemaRestaurant.Properties.Resources.azul;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(658, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(125, 84);
            this.button14.TabIndex = 510;
            this.button14.Text = "MIS VENTAS";
            this.button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.BackColor = System.Drawing.Color.Transparent;
            this.btnHerramientas.BackgroundImage = global::SistemaRestaurant.Properties.Resources.Rojo;
            this.btnHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHerramientas.FlatAppearance.BorderSize = 0;
            this.btnHerramientas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHerramientas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHerramientas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerramientas.ForeColor = System.Drawing.Color.White;
            this.btnHerramientas.Location = new System.Drawing.Point(138, 235);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(125, 84);
            this.btnHerramientas.TabIndex = 504;
            this.btnHerramientas.Text = "Herramientas";
            this.btnHerramientas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHerramientas.UseVisualStyleBackColor = false;
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::SistemaRestaurant.Properties.Resources.naranja;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(12, 235);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 84);
            this.button8.TabIndex = 503;
            this.button8.Text = "Salir";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::SistemaRestaurant.Properties.Resources.verde;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(138, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 84);
            this.button5.TabIndex = 502;
            this.button5.Text = "Cambio de mesa";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::SistemaRestaurant.Properties.Resources.verde;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(12, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 84);
            this.button6.TabIndex = 501;
            this.button6.Text = "Ver cuentas";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::SistemaRestaurant.Properties.Resources.verde;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(138, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 84);
            this.button4.TabIndex = 500;
            this.button4.Text = "Servicio rapido";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SistemaRestaurant.Properties.Resources.verde;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 84);
            this.button1.TabIndex = 499;
            this.button1.Text = "Delibery";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button3.Image = ((System.Drawing.Image)(resources.GetObject("Button3.Image")));
            this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button3.Location = new System.Drawing.Point(0, 126);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(262, 75);
            this.Button3.TabIndex = 8;
            this.Button3.Text = "Cancelar la UNION";
            this.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button3.UseVisualStyleBackColor = false;
            // 
            // Visor_de_mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 749);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Visor_de_mesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor_de_mesas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.PanelBienvienida.ResumeLayout(false);
            this.PanelSalones.ResumeLayout(false);
            this.Panelbotones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATALISTADO_PRODUCTOS_OKA_libre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATALISTADO_PRODUCTOS_OKA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.PanelUNIONMesas.ResumeLayout(false);
            this.PanelUNIONMesas.PerformLayout();
            this.PanelHerramientas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel PanelSalones;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        internal System.Windows.Forms.Panel Panelbotones;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.DataGridView DATALISTADO_PRODUCTOS_OKA_libre;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn2;
        internal System.Windows.Forms.DataGridView DATALISTADO_PRODUCTOS_OKA;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn9;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Panel PanelUNIONMesas;
        internal System.Windows.Forms.Label txtpaso;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Panel PanelBienvienida;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.FlowLayoutPanel PanelMesas;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel PanelHerramientas;
        private System.Windows.Forms.Button btnadministrar;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}