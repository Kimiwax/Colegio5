
namespace Colegio5
{
    partial class AlumnosAgregar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnosAgregar));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombreA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Especificacion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_caracterizacionNA = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_cudA = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_LegajoA = new System.Windows.Forms.TextBox();
            this.cmb_sedeinclusionA = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_localidadAlumno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fechaIngresoA = new System.Windows.Forms.DateTimePicker();
            this.cmb_sexoA = new System.Windows.Forms.ComboBox();
            this.dtp_fechadenacA = new System.Windows.Forms.DateTimePicker();
            this.txt_domicilioA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_obrasocialA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_apellidoA = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_dniA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cerrarVentana1 = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(390, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS DEL ALUMNO";
            // 
            // txt_nombreA
            // 
            this.txt_nombreA.BackColor = System.Drawing.Color.White;
            this.txt_nombreA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombreA.Font = new System.Drawing.Font("Poppins", 11F);
            this.txt_nombreA.ForeColor = System.Drawing.Color.Black;
            this.txt_nombreA.Location = new System.Drawing.Point(30, 36);
            this.txt_nombreA.Name = "txt_nombreA";
            this.txt_nombreA.Size = new System.Drawing.Size(334, 29);
            this.txt_nombreA.TabIndex = 2;
            this.txt_nombreA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "NOMBRE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "FECHA DE NACIMIENTO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(39, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "SEXO:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_Especificacion);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cmb_caracterizacionNA);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cmb_cudA);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txt_LegajoA);
            this.panel1.Controls.Add(this.cmb_sedeinclusionA);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmb_localidadAlumno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp_fechaIngresoA);
            this.panel1.Controls.Add(this.cmb_sexoA);
            this.panel1.Controls.Add(this.dtp_fechadenacA);
            this.panel1.Controls.Add(this.txt_domicilioA);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_obrasocialA);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_apellidoA);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_dniA);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_nombreA);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(58, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 646);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.panel2.Location = new System.Drawing.Point(438, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 578);
            this.panel2.TabIndex = 68;
            // 
            // txt_Especificacion
            // 
            this.txt_Especificacion.BackColor = System.Drawing.Color.White;
            this.txt_Especificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Especificacion.Font = new System.Drawing.Font("Poppins", 11F);
            this.txt_Especificacion.ForeColor = System.Drawing.Color.Black;
            this.txt_Especificacion.Location = new System.Drawing.Point(30, 542);
            this.txt_Especificacion.Name = "txt_Especificacion";
            this.txt_Especificacion.Size = new System.Drawing.Size(334, 29);
            this.txt_Especificacion.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label16.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(39, 511);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 28);
            this.label16.TabIndex = 66;
            this.label16.Text = "ESPECIFICACIÓN:";
            // 
            // cmb_caracterizacionNA
            // 
            this.cmb_caracterizacionNA.BackColor = System.Drawing.Color.White;
            this.cmb_caracterizacionNA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_caracterizacionNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_caracterizacionNA.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_caracterizacionNA.ForeColor = System.Drawing.Color.Black;
            this.cmb_caracterizacionNA.FormattingEnabled = true;
            this.cmb_caracterizacionNA.Items.AddRange(new object[] {
            "TEL - Trastorno Especifíco Del Desarollo",
            "SH - Sordos Hipoacusicos",
            "DV - Ciegos y Disminuidos Visuales",
            "DM - Discapacidad Neuromotora",
            "DI - Discapacidad Intelectual",
            "TES - Trastornos Emocionales Severos"});
            this.cmb_caracterizacionNA.Location = new System.Drawing.Point(30, 398);
            this.cmb_caracterizacionNA.Name = "cmb_caracterizacionNA";
            this.cmb_caracterizacionNA.Size = new System.Drawing.Size(334, 31);
            this.cmb_caracterizacionNA.TabIndex = 65;
            this.cmb_caracterizacionNA.SelectedIndexChanged += new System.EventHandler(this.Selecciona_Caracterizacion);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label15.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(517, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 28);
            this.label15.TabIndex = 64;
            this.label15.Text = "CUD:";
            // 
            // cmb_cudA
            // 
            this.cmb_cudA.BackColor = System.Drawing.Color.White;
            this.cmb_cudA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cudA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_cudA.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_cudA.ForeColor = System.Drawing.Color.Black;
            this.cmb_cudA.FormattingEnabled = true;
            this.cmb_cudA.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmb_cudA.Location = new System.Drawing.Point(508, 110);
            this.cmb_cudA.Name = "cmb_cudA";
            this.cmb_cudA.Size = new System.Drawing.Size(334, 31);
            this.cmb_cudA.TabIndex = 63;
            this.cmb_cudA.SelectedIndexChanged += new System.EventHandler(this.selecciona_cud);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label13.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(41, 439);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 28);
            this.label13.TabIndex = 61;
            this.label13.Text = "LEGAJO:";
            // 
            // txt_LegajoA
            // 
            this.txt_LegajoA.BackColor = System.Drawing.Color.White;
            this.txt_LegajoA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LegajoA.Font = new System.Drawing.Font("Poppins", 11F);
            this.txt_LegajoA.ForeColor = System.Drawing.Color.Black;
            this.txt_LegajoA.Location = new System.Drawing.Point(30, 470);
            this.txt_LegajoA.Name = "txt_LegajoA";
            this.txt_LegajoA.Size = new System.Drawing.Size(334, 29);
            this.txt_LegajoA.TabIndex = 60;
            this.txt_LegajoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LegajoA_KeyPress);
            // 
            // cmb_sedeinclusionA
            // 
            this.cmb_sedeinclusionA.BackColor = System.Drawing.Color.White;
            this.cmb_sedeinclusionA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sedeinclusionA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_sedeinclusionA.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_sedeinclusionA.ForeColor = System.Drawing.Color.Black;
            this.cmb_sedeinclusionA.FormattingEnabled = true;
            this.cmb_sedeinclusionA.Items.AddRange(new object[] {
            "Sede",
            "Inclusión"});
            this.cmb_sedeinclusionA.Location = new System.Drawing.Point(508, 401);
            this.cmb_sedeinclusionA.Name = "cmb_sedeinclusionA";
            this.cmb_sedeinclusionA.Size = new System.Drawing.Size(334, 31);
            this.cmb_sedeinclusionA.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label12.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(517, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 28);
            this.label12.TabIndex = 58;
            this.label12.Text = "SERVICIO:";
            // 
            // cmb_localidadAlumno
            // 
            this.cmb_localidadAlumno.BackColor = System.Drawing.Color.White;
            this.cmb_localidadAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_localidadAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_localidadAlumno.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_localidadAlumno.ForeColor = System.Drawing.Color.Black;
            this.cmb_localidadAlumno.FormattingEnabled = true;
            this.cmb_localidadAlumno.Items.AddRange(new object[] {
            "Alejandro Korn",
            "Longchamps",
            "Burzaco",
            "Doomselar",
            "Guernica",
            "Glew",
            "San Vicente"});
            this.cmb_localidadAlumno.Location = new System.Drawing.Point(508, 184);
            this.cmb_localidadAlumno.Name = "cmb_localidadAlumno";
            this.cmb_localidadAlumno.Size = new System.Drawing.Size(334, 31);
            this.cmb_localidadAlumno.TabIndex = 57;
            this.cmb_localidadAlumno.SelectedIndexChanged += new System.EventHandler(this.selecciona_localidad);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(517, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 28);
            this.label2.TabIndex = 56;
            this.label2.Text = "FECHA DE INGRESO DEL ALUMNO:";
            // 
            // dtp_fechaIngresoA
            // 
            this.dtp_fechaIngresoA.Location = new System.Drawing.Point(508, 329);
            this.dtp_fechaIngresoA.MaxDate = new System.DateTime(2090, 12, 31, 0, 0, 0, 0);
            this.dtp_fechaIngresoA.Name = "dtp_fechaIngresoA";
            this.dtp_fechaIngresoA.Size = new System.Drawing.Size(334, 20);
            this.dtp_fechaIngresoA.TabIndex = 55;
            // 
            // cmb_sexoA
            // 
            this.cmb_sexoA.BackColor = System.Drawing.Color.White;
            this.cmb_sexoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sexoA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_sexoA.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_sexoA.ForeColor = System.Drawing.Color.Black;
            this.cmb_sexoA.FormattingEnabled = true;
            this.cmb_sexoA.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmb_sexoA.Location = new System.Drawing.Point(30, 253);
            this.cmb_sexoA.Name = "cmb_sexoA";
            this.cmb_sexoA.Size = new System.Drawing.Size(334, 31);
            this.cmb_sexoA.TabIndex = 53;
            // 
            // dtp_fechadenacA
            // 
            this.dtp_fechadenacA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_fechadenacA.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechadenacA.Location = new System.Drawing.Point(30, 182);
            this.dtp_fechadenacA.MaxDate = new System.DateTime(2090, 12, 31, 0, 0, 0, 0);
            this.dtp_fechadenacA.Name = "dtp_fechadenacA";
            this.dtp_fechadenacA.Size = new System.Drawing.Size(334, 24);
            this.dtp_fechadenacA.TabIndex = 50;
            // 
            // txt_domicilioA
            // 
            this.txt_domicilioA.BackColor = System.Drawing.Color.White;
            this.txt_domicilioA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_domicilioA.Font = new System.Drawing.Font("Poppins", 11F);
            this.txt_domicilioA.ForeColor = System.Drawing.Color.Black;
            this.txt_domicilioA.Location = new System.Drawing.Point(508, 259);
            this.txt_domicilioA.Name = "txt_domicilioA";
            this.txt_domicilioA.Size = new System.Drawing.Size(334, 29);
            this.txt_domicilioA.TabIndex = 47;
            this.txt_domicilioA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_domicilioA_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(517, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 28);
            this.label8.TabIndex = 46;
            this.label8.Text = "DOMICILIO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(517, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 28);
            this.label7.TabIndex = 44;
            this.label7.Text = "LOCALIDAD:";
            // 
            // txt_obrasocialA
            // 
            this.txt_obrasocialA.BackColor = System.Drawing.Color.White;
            this.txt_obrasocialA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_obrasocialA.Font = new System.Drawing.Font("Poppins", 11F);
            this.txt_obrasocialA.ForeColor = System.Drawing.Color.Black;
            this.txt_obrasocialA.Location = new System.Drawing.Point(508, 36);
            this.txt_obrasocialA.Name = "txt_obrasocialA";
            this.txt_obrasocialA.Size = new System.Drawing.Size(334, 29);
            this.txt_obrasocialA.TabIndex = 41;
            this.txt_obrasocialA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_obrasocialA_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(517, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 28);
            this.label11.TabIndex = 40;
            this.label11.Text = "OBRA SOCIAL:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label14.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(39, 367);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 28);
            this.label14.TabIndex = 36;
            this.label14.Text = "CARACTERIZACIÓN:";
            // 
            // txt_apellidoA
            // 
            this.txt_apellidoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txt_apellidoA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellidoA.Font = new System.Drawing.Font("Poppins", 11F);
            this.txt_apellidoA.ForeColor = System.Drawing.Color.Black;
            this.txt_apellidoA.Location = new System.Drawing.Point(30, 109);
            this.txt_apellidoA.Name = "txt_apellidoA";
            this.txt_apellidoA.Size = new System.Drawing.Size(334, 29);
            this.txt_apellidoA.TabIndex = 34;
            this.txt_apellidoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellidoA_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(159)))), ((int)(((byte)(61)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(81)))), ((int)(((byte)(40)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(558, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 70);
            this.button2.TabIndex = 32;
            this.button2.Text = "SIGUIENTE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(39, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 28);
            this.label9.TabIndex = 27;
            this.label9.Text = "DNI:";
            // 
            // txt_dniA
            // 
            this.txt_dniA.BackColor = System.Drawing.Color.White;
            this.txt_dniA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dniA.Font = new System.Drawing.Font("Poppins", 11F);
            this.txt_dniA.ForeColor = System.Drawing.Color.Black;
            this.txt_dniA.Location = new System.Drawing.Point(30, 328);
            this.txt_dniA.MaxLength = 8;
            this.txt_dniA.Name = "txt_dniA";
            this.txt_dniA.Size = new System.Drawing.Size(334, 29);
            this.txt_dniA.TabIndex = 23;
            this.txt_dniA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dniA_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "APELLIDO:";
            // 
            // btn_cerrarVentana1
            // 
            this.btn_cerrarVentana1.FlatAppearance.BorderSize = 0;
            this.btn_cerrarVentana1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarVentana1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cerrarVentana1.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrarVentana1.Image")));
            this.btn_cerrarVentana1.Location = new System.Drawing.Point(5, 3);
            this.btn_cerrarVentana1.Name = "btn_cerrarVentana1";
            this.btn_cerrarVentana1.Size = new System.Drawing.Size(34, 41);
            this.btn_cerrarVentana1.TabIndex = 24;
            this.btn_cerrarVentana1.UseVisualStyleBackColor = true;
            this.btn_cerrarVentana1.Click += new System.EventHandler(this.btn_cerrarVentana1_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            this.errorIcono.Icon = ((System.Drawing.Icon)(resources.GetObject("errorIcono.Icon")));
            // 
            // AlumnosAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.btn_cerrarVentana1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlumnosAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlumnosAgregar";
            this.Load += new System.EventHandler(this.AlumnosAgregar_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombreA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_dniA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_apellidoA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_obrasocialA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_domicilioA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_fechadenacA;
        private System.Windows.Forms.ComboBox cmb_sexoA;
        private System.Windows.Forms.ComboBox cmb_localidadAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fechaIngresoA;
        private System.Windows.Forms.ComboBox cmb_sedeinclusionA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_LegajoA;
        private System.Windows.Forms.Button btn_cerrarVentana1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_cudA;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ComboBox cmb_caracterizacionNA;
        private System.Windows.Forms.TextBox txt_Especificacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
    }
}