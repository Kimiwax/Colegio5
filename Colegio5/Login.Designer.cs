
namespace Colegio5
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_invitado = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox_Usuario = new System.Windows.Forms.PictureBox();
            this.pictureBox_Invitado = new System.Windows.Forms.PictureBox();
            this.pictureBox_Admin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Invitado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_invitado);
            this.panel1.Controls.Add(this.lbl_admin);
            this.panel1.Controls.Add(this.pictureBox_Invitado);
            this.panel1.Controls.Add(this.pictureBox_Admin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 487);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione su usuario";
            // 
            // lbl_invitado
            // 
            this.lbl_invitado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_invitado.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invitado.ForeColor = System.Drawing.Color.White;
            this.lbl_invitado.Location = new System.Drawing.Point(57, 416);
            this.lbl_invitado.Name = "lbl_invitado";
            this.lbl_invitado.Size = new System.Drawing.Size(76, 26);
            this.lbl_invitado.TabIndex = 4;
            this.lbl_invitado.Text = "Invitado";
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_admin.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.Color.White;
            this.lbl_admin.Location = new System.Drawing.Point(36, 224);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(123, 26);
            this.lbl_admin.TabIndex = 3;
            this.lbl_admin.Text = "Administrador";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_usuario.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(422, 222);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(137, 39);
            this.lbl_usuario.TabIndex = 4;
            this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(394, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingrese su contraseña";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contraseña.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txt_contraseña.Location = new System.Drawing.Point(381, 315);
            this.txt_contraseña.MaxLength = 10;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(214, 30);
            this.txt_contraseña.TabIndex = 6;
            this.txt_contraseña.Text = "INGRESE SU CONTRASEÑA";
            this.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_contraseña.Enter += new System.EventHandler(this.txt_contraseña_Enter);
            this.txt_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contraseña_KeyPress);
            this.txt_contraseña.Leave += new System.EventHandler(this.txt_contraseña_Leave);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.Location = new System.Drawing.Point(427, 362);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(118, 47);
            this.btn_ingresar.TabIndex = 7;
            this.btn_ingresar.Text = "INGRESAR";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Colegio5.Properties.Resources.cerrarVentanaIcono;
            this.button1.Location = new System.Drawing.Point(750, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 46);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_Usuario
            // 
            this.pictureBox_Usuario.Location = new System.Drawing.Point(395, 59);
            this.pictureBox_Usuario.Name = "pictureBox_Usuario";
            this.pictureBox_Usuario.Size = new System.Drawing.Size(190, 190);
            this.pictureBox_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Usuario.TabIndex = 2;
            this.pictureBox_Usuario.TabStop = false;
            // 
            // pictureBox_Invitado
            // 
            this.pictureBox_Invitado.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Invitado.Image")));
            this.pictureBox_Invitado.Location = new System.Drawing.Point(0, 250);
            this.pictureBox_Invitado.Name = "pictureBox_Invitado";
            this.pictureBox_Invitado.Size = new System.Drawing.Size(190, 192);
            this.pictureBox_Invitado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Invitado.TabIndex = 2;
            this.pictureBox_Invitado.TabStop = false;
            this.pictureBox_Invitado.Click += new System.EventHandler(this.pictureBox_Invitado_Click);
            this.pictureBox_Invitado.MouseEnter += new System.EventHandler(this.pictureBox_Invitado_MouseEnter);
            this.pictureBox_Invitado.MouseLeave += new System.EventHandler(this.pictureBox_Invitado_MouseLeave);
            // 
            // pictureBox_Admin
            // 
            this.pictureBox_Admin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Admin.Image")));
            this.pictureBox_Admin.Location = new System.Drawing.Point(0, 62);
            this.pictureBox_Admin.Name = "pictureBox_Admin";
            this.pictureBox_Admin.Size = new System.Drawing.Size(190, 190);
            this.pictureBox_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Admin.TabIndex = 1;
            this.pictureBox_Admin.TabStop = false;
            this.pictureBox_Admin.Click += new System.EventHandler(this.pictureBox_Admin_Click);
            this.pictureBox_Admin.MouseEnter += new System.EventHandler(this.pictureBox_Admin_MouseEnter);
            this.pictureBox_Admin.MouseLeave += new System.EventHandler(this.pictureBox_Admin_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox_Usuario);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Invitado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_Invitado;
        private System.Windows.Forms.PictureBox pictureBox_Admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_invitado;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.PictureBox pictureBox_Usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button button1;
    }
}