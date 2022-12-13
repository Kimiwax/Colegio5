
namespace Colegio5
{
    partial class GrupoAgregar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_caracterizacionAMod = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_Grupo = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmb_CicloGrup = new System.Windows.Forms.ComboBox();
            this.cmb_turno = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_nombreGrupo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_crearGrupo = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lstBox_Docente = new System.Windows.Forms.ListBox();
            this.lstBox_Alumnos = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grupo)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.cmb_caracterizacionAMod);
            this.panel3.Controls.Add(this.btn_buscar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 68);
            this.panel3.TabIndex = 4;
            // 
            // cmb_caracterizacionAMod
            // 
            this.cmb_caracterizacionAMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.cmb_caracterizacionAMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_caracterizacionAMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_caracterizacionAMod.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_caracterizacionAMod.ForeColor = System.Drawing.Color.White;
            this.cmb_caracterizacionAMod.FormattingEnabled = true;
            this.cmb_caracterizacionAMod.Items.AddRange(new object[] {
            "TEL - Trastorno Especifíco Del Desarollo",
            "SH - Sordos Hipoacusicos",
            "DV - Ciegos y Disminuidos Visuales",
            "DM - Discapacidad Neuromotora",
            "DI - Discapacidad Intelectual",
            "TES - Trastornos Emocionales Severos"});
            this.cmb_caracterizacionAMod.Location = new System.Drawing.Point(12, 35);
            this.cmb_caracterizacionAMod.Name = "cmb_caracterizacionAMod";
            this.cmb_caracterizacionAMod.Size = new System.Drawing.Size(229, 26);
            this.cmb_caracterizacionAMod.TabIndex = 97;
            this.cmb_caracterizacionAMod.SelectedIndexChanged += new System.EventHandler(this.cmb_caracterizacionAMod_SelectedIndexChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(269, 15);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(130, 37);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar Caracterización";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel4.Controls.Add(this.dgv_Grupo);
            this.panel4.Location = new System.Drawing.Point(12, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(426, 529);
            this.panel4.TabIndex = 12;
            // 
            // dgv_Grupo
            // 
            this.dgv_Grupo.AllowUserToAddRows = false;
            this.dgv_Grupo.AllowUserToDeleteRows = false;
            this.dgv_Grupo.AllowUserToResizeColumns = false;
            this.dgv_Grupo.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Grupo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Grupo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.dgv_Grupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Grupo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Grupo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Grupo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_Grupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Grupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Column2,
            this.Column3,
            this.Tipo});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Grupo.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Grupo.EnableHeadersVisualStyles = false;
            this.dgv_Grupo.GridColor = System.Drawing.Color.White;
            this.dgv_Grupo.Location = new System.Drawing.Point(12, 12);
            this.dgv_Grupo.Name = "dgv_Grupo";
            this.dgv_Grupo.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Grupo.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_Grupo.RowHeadersVisible = false;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Grupo.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_Grupo.Size = new System.Drawing.Size(401, 500);
            this.dgv_Grupo.TabIndex = 4;
            this.dgv_Grupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // DNI
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI.DefaultCellStyle = dataGridViewCellStyle15;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.cmb_CicloGrup);
            this.panel5.Controls.Add(this.cmb_turno);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.txt_nombreGrupo);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.btn_crearGrupo);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.lstBox_Docente);
            this.panel5.Controls.Add(this.lstBox_Alumnos);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(444, 131);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(494, 441);
            this.panel5.TabIndex = 13;
            // 
            // cmb_CicloGrup
            // 
            this.cmb_CicloGrup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.cmb_CicloGrup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_CicloGrup.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CicloGrup.ForeColor = System.Drawing.Color.White;
            this.cmb_CicloGrup.FormattingEnabled = true;
            this.cmb_CicloGrup.ItemHeight = 18;
            this.cmb_CicloGrup.Items.AddRange(new object[] {
            "ATDI",
            "2DO CICLO INICIAL",
            "1ER CICLO PRIMARIO",
            "2DO CICLO PRIMARIO",
            "SECUNDARIA BASICA",
            "SECUNDARIA SUPERIOR"});
            this.cmb_CicloGrup.Location = new System.Drawing.Point(356, 142);
            this.cmb_CicloGrup.Name = "cmb_CicloGrup";
            this.cmb_CicloGrup.Size = new System.Drawing.Size(120, 26);
            this.cmb_CicloGrup.TabIndex = 35;
            this.cmb_CicloGrup.SelectedIndexChanged += new System.EventHandler(this.cmb_CicloGrup_SelectedIndexChanged);
            // 
            // cmb_turno
            // 
            this.cmb_turno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.cmb_turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_turno.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_turno.ForeColor = System.Drawing.Color.White;
            this.cmb_turno.FormattingEnabled = true;
            this.cmb_turno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.cmb_turno.Location = new System.Drawing.Point(356, 204);
            this.cmb_turno.Name = "cmb_turno";
            this.cmb_turno.Size = new System.Drawing.Size(120, 26);
            this.cmb_turno.TabIndex = 33;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(191, 149);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 18);
            this.label22.TabIndex = 31;
            this.label22.Text = "Nombre del grupo";
            // 
            // txt_nombreGrupo
            // 
            this.txt_nombreGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.txt_nombreGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombreGrupo.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreGrupo.ForeColor = System.Drawing.Color.White;
            this.txt_nombreGrupo.Location = new System.Drawing.Point(195, 177);
            this.txt_nombreGrupo.Name = "txt_nombreGrupo";
            this.txt_nombreGrupo.Size = new System.Drawing.Size(122, 21);
            this.txt_nombreGrupo.TabIndex = 30;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(385, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 18);
            this.label19.TabIndex = 27;
            this.label19.Text = "CICLO";
            // 
            // btn_crearGrupo
            // 
            this.btn_crearGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_crearGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearGrupo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearGrupo.ForeColor = System.Drawing.Color.White;
            this.btn_crearGrupo.Location = new System.Drawing.Point(171, 377);
            this.btn_crearGrupo.Name = "btn_crearGrupo";
            this.btn_crearGrupo.Size = new System.Drawing.Size(171, 49);
            this.btn_crearGrupo.TabIndex = 25;
            this.btn_crearGrupo.Text = "CREAR GRUPO";
            this.btn_crearGrupo.UseVisualStyleBackColor = true;
            this.btn_crearGrupo.Click += new System.EventHandler(this.btn_crearGrupo_Click_1);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(385, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 18);
            this.label17.TabIndex = 23;
            this.label17.Text = "TURNO";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(218, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 18);
            this.label16.TabIndex = 22;
            this.label16.Text = "DOCENTE";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(37, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 18);
            this.label15.TabIndex = 21;
            this.label15.Text = "ALUMNOS";
            // 
            // lstBox_Docente
            // 
            this.lstBox_Docente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.lstBox_Docente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBox_Docente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstBox_Docente.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox_Docente.ForeColor = System.Drawing.Color.White;
            this.lstBox_Docente.FormattingEnabled = true;
            this.lstBox_Docente.ItemHeight = 15;
            this.lstBox_Docente.Location = new System.Drawing.Point(185, 81);
            this.lstBox_Docente.Name = "lstBox_Docente";
            this.lstBox_Docente.Size = new System.Drawing.Size(143, 45);
            this.lstBox_Docente.TabIndex = 20;
            // 
            // lstBox_Alumnos
            // 
            this.lstBox_Alumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.lstBox_Alumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBox_Alumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstBox_Alumnos.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox_Alumnos.ForeColor = System.Drawing.Color.White;
            this.lstBox_Alumnos.FormattingEnabled = true;
            this.lstBox_Alumnos.ItemHeight = 15;
            this.lstBox_Alumnos.Location = new System.Drawing.Point(12, 81);
            this.lstBox_Alumnos.Name = "lstBox_Alumnos";
            this.lstBox_Alumnos.Size = new System.Drawing.Size(143, 240);
            this.lstBox_Alumnos.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(187, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 26);
            this.label14.TabIndex = 18;
            this.label14.Text = "Crear grupo";
            // 
            // GrupoAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(950, 627);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrupoAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GruposSede";
            this.Load += new System.EventHandler(this.GrupoAgregar_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grupo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_Grupo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_crearGrupo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lstBox_Docente;
        private System.Windows.Forms.ListBox lstBox_Alumnos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_nombreGrupo;
        private System.Windows.Forms.ComboBox cmb_CicloGrup;
        private System.Windows.Forms.ComboBox cmb_turno;
        private System.Windows.Forms.ComboBox cmb_caracterizacionAMod;
    }
}