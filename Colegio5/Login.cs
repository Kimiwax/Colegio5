using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseVariables;
using MetodosColeg;

namespace Colegio5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      

        private void pictureBox_Admin_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Admin.BackColor = Color.FromArgb(83, 185, 118);
            lbl_admin.BackColor = Color.FromArgb(83, 185, 118);

        }

        private void pictureBox_Admin_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Admin.BackColor = Color.FromArgb(23, 28, 38);
            lbl_admin.BackColor = Color.FromArgb(23, 28, 38);
        }

        private void pictureBox_Invitado_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Invitado.BackColor = Color.FromArgb(234, 121, 46);
            lbl_invitado.BackColor = Color.FromArgb(234, 121, 46);
        }

        private void pictureBox_Invitado_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Invitado.BackColor = Color.FromArgb(23, 28, 38);
            lbl_invitado.BackColor = Color.FromArgb(23, 28, 38);
        }

        private void pictureBox_Admin_Click(object sender, EventArgs e)
        {
            pictureBox_Usuario.Image = pictureBox_Admin.Image;
            lbl_usuario.Text = lbl_admin.Text;
            Variables.user2 = false;
            Variables.user1 = true;
            
        }

        private void pictureBox_Invitado_Click(object sender, EventArgs e)
        {
            pictureBox_Usuario.Image = pictureBox_Invitado.Image;
            lbl_usuario.Text = lbl_invitado.Text;
            Variables.user1 = false;
            Variables.user2 = true;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            
            if (Variables.user1 && txt_contraseña.Text == "admin")
            {
                this.Hide();
                Inicio f1 = new Inicio();
                f1.Show();
            }
            else if (Variables.user2 && txt_contraseña.Text == "guess")
            {
                this.Hide();
                Inicio f1 = new Inicio();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void txt_contraseña_Enter(object sender, EventArgs e)
        {
            if(txt_contraseña.Text == "INGRESE SU CONTRASEÑA")
            {
                txt_contraseña.Text = "";
                txt_contraseña.ForeColor = Color.LightGray;
            } 
        }

        private void txt_contraseña_Leave(object sender, EventArgs e)
        {
            if(txt_contraseña.Text == ""){
                txt_contraseña.Text = "INGRESE SU CONTRASEÑA";
                txt_contraseña.ForeColor = Color.DimGray;
            }
        }
        /*
        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosColeg.Metodos.ValidarNumeros(e);
        }*/
    }
}
