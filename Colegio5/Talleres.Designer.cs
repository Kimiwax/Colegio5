
namespace Colegio5
{
    partial class Talleres
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_crearTaller = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.panelTop.Controls.Add(this.btn_buscar);
            this.panelTop.Controls.Add(this.btn_crearTaller);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(950, 73);
            this.panelTop.TabIndex = 7;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(483, 15);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(130, 37);
            this.btn_buscar.TabIndex = 27;
            this.btn_buscar.Text = "VER";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_crearTaller
            // 
            this.btn_crearTaller.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_crearTaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crearTaller.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearTaller.ForeColor = System.Drawing.Color.White;
            this.btn_crearTaller.Location = new System.Drawing.Point(327, 15);
            this.btn_crearTaller.Name = "btn_crearTaller";
            this.btn_crearTaller.Size = new System.Drawing.Size(130, 37);
            this.btn_crearTaller.TabIndex = 26;
            this.btn_crearTaller.Text = "CREAR";
            this.btn_crearTaller.UseVisualStyleBackColor = true;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.panelPrincipal.Location = new System.Drawing.Point(1, 70);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(948, 556);
            this.panelPrincipal.TabIndex = 8;
            // 
            // Talleres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(950, 627);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Talleres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarInstancias";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_crearTaller;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}