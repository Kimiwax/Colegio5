using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseVariables;
using MetodosColeg;

namespace Colegio5
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            Image img = Image.FromFile("user1Icono.png");
            Image img2 = Image.FromFile("user2Icono.png");
            if (Variables.user1)
            {
                pictureBox_UsuarioSel.Image = img;
            }
            else
            {
                pictureBox_UsuarioSel.Image = img2;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //panelContenedor.Controls.Clear();
            System.Diagnostics.Process.Start("Instructivo.pdf");
            
            //lbl_topPanel.Text = "Instructivo";
            //panelTop.BackColor = Color.FromArgb(254, 202, 87);
        }

      

        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Metodos.AbrirFormHijo(new Alumnos(), this.panelContenedor);

      
            lbl_topPanel.Text = "Alumnos";
            panelTop.BackColor = Color.FromArgb(9, 132, 227);
            

        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Metodos.AbrirFormHijo(new Docentes(), this.panelContenedor);
          
            lbl_topPanel.Text = "Docentes";
            panelTop.BackColor = Color.FromArgb(255, 127, 80);
            
        }

        private void btn_alumnos_MouseEnter(object sender, EventArgs e)
        {
            btn_alumnos.BackColor = Color.FromArgb(9, 132, 227);
            btn_alumnos.FlatAppearance.BorderSize = 1;
            
        }

        private void btn_alumnos_MouseLeave(object sender, EventArgs e)
        {
            btn_alumnos.BackColor = Color.FromArgb(42, 47, 87);
            btn_alumnos.FlatAppearance.BorderSize = 0;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(255, 127, 80);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(42,47,87);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(32, 191, 107);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(42, 47, 87);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(255, 71, 87);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(42, 47, 87);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Metodos.AbrirFormHijo(new Grupos(), this.panelContenedor);
           
            lbl_topPanel.Text = "Grupos";
            panelTop.BackColor = Color.FromArgb(32, 191, 107);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btn_agregar_MouseEnter(object sender, EventArgs e)
        {
            btn_instrucciones.BackColor = Color.FromArgb(254, 202, 87);
        }

        private void btn_agregar_MouseLeave(object sender, EventArgs e)
        {
            btn_instrucciones.BackColor = Color.FromArgb(42, 47, 87);
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
