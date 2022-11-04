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

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_topPanel.Text = "Hola";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormAlumnos(new AgregarInstancias());
            lbl_topPanel.Text = "Crear";
            panelTop.BackColor = Color.FromArgb(254, 202, 87);
        }

        public void abrirFormAlumnos(object formHijo)
        {

            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            
        }

        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            abrirFormAlumnos(new Alumnos());
            lbl_topPanel.Text = "Alumnos";
            panelTop.BackColor = Color.FromArgb(9, 132, 227);
            panel2.Enabled = false;
            panel2.Visible = false;
            panel3.Enabled = false;
            panel3.Visible = false;

        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            abrirFormAlumnos(new Docentes());
            lbl_topPanel.Text = "Docentes";
            panelTop.BackColor = Color.FromArgb(255, 127, 80);
            panel2.Enabled = false;
            panel2.Visible = false;
            panel3.Enabled = false;
            panel3.Visible = false;
        }

        private void btn_alumnos_MouseEnter(object sender, EventArgs e)
        {
            btn_alumnos.BackColor = Color.FromArgb(9, 132, 227);
            
        }

        private void btn_alumnos_MouseLeave(object sender, EventArgs e)
        {
            btn_alumnos.BackColor = Color.FromArgb(42, 47, 87);
           
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
            button2.BackColor = Color.FromArgb(123, 237, 159);
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
            abrirFormAlumnos(new Grupos());
            lbl_topPanel.Text = "Grupos";
            panelTop.BackColor = Color.FromArgb(123, 237, 159);
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
            btn_agregar.BackColor = Color.FromArgb(254, 202, 87);
        }

        private void btn_agregar_MouseLeave(object sender, EventArgs e)
        {
            btn_agregar.BackColor = Color.FromArgb(42, 47, 87);
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
