
namespace Colegio5
{
    partial class Alumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_alumnos = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caracterizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelContenedorServicio = new System.Windows.Forms.Panel();
            this.rb_sede = new System.Windows.Forms.RadioButton();
            this.rb_inc = new System.Windows.Forms.RadioButton();
            this.panelContenedorCaracterizaciones = new System.Windows.Forms.Panel();
            this.rb_caracterizacion9 = new System.Windows.Forms.RadioButton();
            this.rb_caracterizacion2 = new System.Windows.Forms.RadioButton();
            this.rb_caracterizacion6 = new System.Windows.Forms.RadioButton();
            this.rb_caracterizacion3 = new System.Windows.Forms.RadioButton();
            this.rb_caracterizacion5 = new System.Windows.Forms.RadioButton();
            this.rb_caracterizacion4 = new System.Windows.Forms.RadioButton();
            this.cmb_filtros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscarDni = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumnos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelContenedorServicio.SuspendLayout();
            this.panelContenedorCaracterizaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btn_imprimir);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dgv_alumnos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.txt_buscarDni);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 552);
            this.panel1.TabIndex = 2;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.FlatAppearance.BorderSize = 2;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_imprimir.Location = new System.Drawing.Point(48, 96);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(146, 33);
            this.btn_imprimir.TabIndex = 9;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.panel5.Location = new System.Drawing.Point(0, 134);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(926, 5);
            this.panel5.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.panel4.Location = new System.Drawing.Point(0, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(926, 5);
            this.panel4.TabIndex = 7;
            // 
            // dgv_alumnos
            // 
            this.dgv_alumnos.AllowUserToAddRows = false;
            this.dgv_alumnos.AllowUserToDeleteRows = false;
            this.dgv_alumnos.AllowUserToResizeColumns = false;
            this.dgv_alumnos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_alumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_alumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_alumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_alumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.dgv_alumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_alumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_alumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Nombre,
            this.Apellido,
            this.Caracterizacion,
            this.Localidad,
            this.Direccion});
            this.dgv_alumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_alumnos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_alumnos.EnableHeadersVisualStyles = false;
            this.dgv_alumnos.GridColor = System.Drawing.Color.White;
            this.dgv_alumnos.Location = new System.Drawing.Point(14, 143);
            this.dgv_alumnos.Name = "dgv_alumnos";
            this.dgv_alumnos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_alumnos.RowHeadersVisible = false;
            this.dgv_alumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_alumnos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_alumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_alumnos.Size = new System.Drawing.Size(897, 387);
            this.dgv_alumnos.TabIndex = 4;
            this.dgv_alumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_alumnos_CellClick);
            this.dgv_alumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_alumnos_CellDoubleClick);
            // 
            // Dni
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dni.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            this.Dni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Caracterizacion
            // 
            this.Caracterizacion.HeaderText = "Caracterizacion";
            this.Caracterizacion.Name = "Caracterizacion";
            this.Caracterizacion.ReadOnly = true;
            this.Caracterizacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            this.Localidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.panelContenedorServicio);
            this.panel3.Controls.Add(this.panelContenedorCaracterizaciones);
            this.panel3.Controls.Add(this.cmb_filtros);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(14, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(897, 87);
            this.panel3.TabIndex = 3;
            // 
            // panelContenedorServicio
            // 
            this.panelContenedorServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.panelContenedorServicio.Controls.Add(this.rb_sede);
            this.panelContenedorServicio.Controls.Add(this.rb_inc);
            this.panelContenedorServicio.Enabled = false;
            this.panelContenedorServicio.Location = new System.Drawing.Point(246, 29);
            this.panelContenedorServicio.Name = "panelContenedorServicio";
            this.panelContenedorServicio.Size = new System.Drawing.Size(182, 36);
            this.panelContenedorServicio.TabIndex = 29;
            this.panelContenedorServicio.Visible = false;
            // 
            // rb_sede
            // 
            this.rb_sede.AutoSize = true;
            this.rb_sede.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sede.ForeColor = System.Drawing.Color.White;
            this.rb_sede.Location = new System.Drawing.Point(8, 10);
            this.rb_sede.Name = "rb_sede";
            this.rb_sede.Size = new System.Drawing.Size(53, 19);
            this.rb_sede.TabIndex = 13;
            this.rb_sede.TabStop = true;
            this.rb_sede.Text = "Sede";
            this.rb_sede.UseVisualStyleBackColor = true;
            this.rb_sede.CheckedChanged += new System.EventHandler(this.rb_sede_CheckedChanged);
            // 
            // rb_inc
            // 
            this.rb_inc.AutoSize = true;
            this.rb_inc.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inc.ForeColor = System.Drawing.Color.White;
            this.rb_inc.Location = new System.Drawing.Point(92, 10);
            this.rb_inc.Name = "rb_inc";
            this.rb_inc.Size = new System.Drawing.Size(73, 19);
            this.rb_inc.TabIndex = 16;
            this.rb_inc.TabStop = true;
            this.rb_inc.Text = "Inclusión";
            this.rb_inc.UseVisualStyleBackColor = true;
            this.rb_inc.CheckedChanged += new System.EventHandler(this.rb_inc_CheckedChanged);
            // 
            // panelContenedorCaracterizaciones
            // 
            this.panelContenedorCaracterizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorCaracterizaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.panelContenedorCaracterizaciones.Controls.Add(this.rb_caracterizacion9);
            this.panelContenedorCaracterizaciones.Controls.Add(this.rb_caracterizacion2);
            this.panelContenedorCaracterizaciones.Controls.Add(this.rb_caracterizacion6);
            this.panelContenedorCaracterizaciones.Controls.Add(this.rb_caracterizacion3);
            this.panelContenedorCaracterizaciones.Controls.Add(this.rb_caracterizacion5);
            this.panelContenedorCaracterizaciones.Controls.Add(this.rb_caracterizacion4);
            this.panelContenedorCaracterizaciones.Enabled = false;
            this.panelContenedorCaracterizaciones.Location = new System.Drawing.Point(264, 6);
            this.panelContenedorCaracterizaciones.Name = "panelContenedorCaracterizaciones";
            this.panelContenedorCaracterizaciones.Size = new System.Drawing.Size(418, 74);
            this.panelContenedorCaracterizaciones.TabIndex = 28;
            this.panelContenedorCaracterizaciones.Visible = false;
            // 
            // rb_caracterizacion9
            // 
            this.rb_caracterizacion9.AutoSize = true;
            this.rb_caracterizacion9.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_caracterizacion9.ForeColor = System.Drawing.Color.White;
            this.rb_caracterizacion9.Location = new System.Drawing.Point(198, 50);
            this.rb_caracterizacion9.Name = "rb_caracterizacion9";
            this.rb_caracterizacion9.Size = new System.Drawing.Size(170, 19);
            this.rb_caracterizacion9.TabIndex = 18;
            this.rb_caracterizacion9.TabStop = true;
            this.rb_caracterizacion9.Text = "Discapacidad neuromotora";
            this.rb_caracterizacion9.UseVisualStyleBackColor = true;
            this.rb_caracterizacion9.CheckedChanged += new System.EventHandler(this.rb_caracterizacion9_CheckedChanged);
            // 
            // rb_caracterizacion2
            // 
            this.rb_caracterizacion2.AutoSize = true;
            this.rb_caracterizacion2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_caracterizacion2.ForeColor = System.Drawing.Color.White;
            this.rb_caracterizacion2.Location = new System.Drawing.Point(8, 10);
            this.rb_caracterizacion2.Name = "rb_caracterizacion2";
            this.rb_caracterizacion2.Size = new System.Drawing.Size(134, 19);
            this.rb_caracterizacion2.TabIndex = 13;
            this.rb_caracterizacion2.TabStop = true;
            this.rb_caracterizacion2.Text = "Sordos hipoacusicos";
            this.rb_caracterizacion2.UseVisualStyleBackColor = true;
            this.rb_caracterizacion2.CheckedChanged += new System.EventHandler(this.rb_caracterizacion2_CheckedChanged);
            // 
            // rb_caracterizacion6
            // 
            this.rb_caracterizacion6.AutoSize = true;
            this.rb_caracterizacion6.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_caracterizacion6.ForeColor = System.Drawing.Color.White;
            this.rb_caracterizacion6.Location = new System.Drawing.Point(198, 30);
            this.rb_caracterizacion6.Name = "rb_caracterizacion6";
            this.rb_caracterizacion6.Size = new System.Drawing.Size(196, 19);
            this.rb_caracterizacion6.TabIndex = 17;
            this.rb_caracterizacion6.TabStop = true;
            this.rb_caracterizacion6.Text = "Trastornos emocionales severos";
            this.rb_caracterizacion6.UseVisualStyleBackColor = true;
            this.rb_caracterizacion6.CheckedChanged += new System.EventHandler(this.rb_caracterizacion6_CheckedChanged);
            // 
            // rb_caracterizacion3
            // 
            this.rb_caracterizacion3.AutoSize = true;
            this.rb_caracterizacion3.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_caracterizacion3.ForeColor = System.Drawing.Color.White;
            this.rb_caracterizacion3.Location = new System.Drawing.Point(8, 30);
            this.rb_caracterizacion3.Name = "rb_caracterizacion3";
            this.rb_caracterizacion3.Size = new System.Drawing.Size(186, 19);
            this.rb_caracterizacion3.TabIndex = 14;
            this.rb_caracterizacion3.TabStop = true;
            this.rb_caracterizacion3.Text = "Ciegos y disminuidos visuales";
            this.rb_caracterizacion3.UseVisualStyleBackColor = true;
            this.rb_caracterizacion3.CheckedChanged += new System.EventHandler(this.rb_caracterizacion3_CheckedChanged);
            // 
            // rb_caracterizacion5
            // 
            this.rb_caracterizacion5.AutoSize = true;
            this.rb_caracterizacion5.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_caracterizacion5.ForeColor = System.Drawing.Color.White;
            this.rb_caracterizacion5.Location = new System.Drawing.Point(198, 10);
            this.rb_caracterizacion5.Name = "rb_caracterizacion5";
            this.rb_caracterizacion5.Size = new System.Drawing.Size(213, 19);
            this.rb_caracterizacion5.TabIndex = 16;
            this.rb_caracterizacion5.TabStop = true;
            this.rb_caracterizacion5.Text = "Trastornos especificos del lenguaje";
            this.rb_caracterizacion5.UseVisualStyleBackColor = true;
            this.rb_caracterizacion5.CheckedChanged += new System.EventHandler(this.rb_caracterizacion5_CheckedChanged);
            // 
            // rb_caracterizacion4
            // 
            this.rb_caracterizacion4.AutoSize = true;
            this.rb_caracterizacion4.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_caracterizacion4.ForeColor = System.Drawing.Color.White;
            this.rb_caracterizacion4.Location = new System.Drawing.Point(8, 50);
            this.rb_caracterizacion4.Name = "rb_caracterizacion4";
            this.rb_caracterizacion4.Size = new System.Drawing.Size(156, 19);
            this.rb_caracterizacion4.TabIndex = 15;
            this.rb_caracterizacion4.TabStop = true;
            this.rb_caracterizacion4.Text = "Discapacidad intelectual";
            this.rb_caracterizacion4.UseVisualStyleBackColor = true;
            this.rb_caracterizacion4.CheckedChanged += new System.EventHandler(this.rb_caracterizacion4_CheckedChanged);
            // 
            // cmb_filtros
            // 
            this.cmb_filtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.cmb_filtros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_filtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_filtros.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_filtros.ForeColor = System.Drawing.Color.White;
            this.cmb_filtros.FormattingEnabled = true;
            this.cmb_filtros.Items.AddRange(new object[] {
            "Todos",
            "Caracterización",
            "Servicios",
            "Alumnos de Baja"});
            this.cmb_filtros.Location = new System.Drawing.Point(34, 29);
            this.cmb_filtros.Name = "cmb_filtros";
            this.cmb_filtros.Size = new System.Drawing.Size(156, 23);
            this.cmb_filtros.TabIndex = 7;
            this.cmb_filtros.SelectedIndexChanged += new System.EventHandler(this.cmb_filtros_SelectedIndexChanged);
            this.cmb_filtros.SelectedValueChanged += new System.EventHandler(this.cmb_filtros_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "FILTROS DE BUSQUEDA";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderSize = 2;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(765, 98);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(146, 31);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscarDni
            // 
            this.txt_buscarDni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscarDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.txt_buscarDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscarDni.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarDni.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_buscarDni.Location = new System.Drawing.Point(477, 100);
            this.txt_buscarDni.MaxLength = 8;
            this.txt_buscarDni.Name = "txt_buscarDni";
            this.txt_buscarDni.Size = new System.Drawing.Size(271, 24);
            this.txt_buscarDni.TabIndex = 6;
            this.txt_buscarDni.Text = "Ingrese DNI";
            this.txt_buscarDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_buscarDni.Enter += new System.EventHandler(this.txt_buscarDni_Enter);
            this.txt_buscarDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscarDni_KeyPress);
            this.txt_buscarDni.Leave += new System.EventHandler(this.txt_buscarDni_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.pictureBox1.Image = global::Colegio5.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(447, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(738, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "AGREGAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "LISTA DE ALUMNOS";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 57);
            this.panel2.TabIndex = 1;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(950, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumnos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelContenedorServicio.ResumeLayout(false);
            this.panelContenedorServicio.PerformLayout();
            this.panelContenedorCaracterizaciones.ResumeLayout(false);
            this.panelContenedorCaracterizaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_alumnos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_filtros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caracterizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.TextBox txt_buscarDni;
        private System.Windows.Forms.Panel panelContenedorCaracterizaciones;
        private System.Windows.Forms.RadioButton rb_caracterizacion9;
        private System.Windows.Forms.RadioButton rb_caracterizacion6;
        private System.Windows.Forms.RadioButton rb_caracterizacion5;
        private System.Windows.Forms.RadioButton rb_caracterizacion4;
        private System.Windows.Forms.RadioButton rb_caracterizacion3;
        private System.Windows.Forms.RadioButton rb_caracterizacion2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelContenedorServicio;
        private System.Windows.Forms.RadioButton rb_sede;
        private System.Windows.Forms.RadioButton rb_inc;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}