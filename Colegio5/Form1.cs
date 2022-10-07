using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colegio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            abrirFormAlumnos(new Alumnos());
            lbl_topPanel.Text = "Alumnos";
            panelTop.BackColor = Color.FromArgb(112, 161, 255);


        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            abrirFormAlumnos(new AgregarDocentes());
            lbl_topPanel.Text = "Docentes";
            panelTop.BackColor = Color.FromArgb(255, 127, 80);
        }

        private void btn_alumnos_MouseEnter(object sender, EventArgs e)
        {
            btn_alumnos.BackColor = Color.FromArgb(112, 161, 255);
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
    }
}
