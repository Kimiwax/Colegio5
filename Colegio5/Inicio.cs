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
            autocompletar();
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

      
            lbl_topPanel.Text = "ALUMNOS";
            panelTop.BackColor = Color.FromArgb(87, 173, 221);
            

        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Metodos.AbrirFormHijo(new Docentes(), this.panelContenedor);
          
            lbl_topPanel.Text = "DOCENTES";
            panelTop.BackColor = Color.FromArgb(241, 162, 87);
            
        }

        private void btn_alumnos_MouseEnter(object sender, EventArgs e)
        {
            btn_alumnos.BackColor = Color.FromArgb(122, 174, 234);
            btn_alumnos.FlatAppearance.BorderSize = 1;
            
        }

        private void btn_alumnos_MouseLeave(object sender, EventArgs e)
        {
            btn_alumnos.BackColor = Color.FromArgb(33, 39, 52);
            btn_alumnos.FlatAppearance.BorderSize = 0;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(241, 162, 87);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(33, 39, 52);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(108, 179, 81);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(33, 39, 52);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(204, 70, 88);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(33, 39, 52);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Metodos.AbrirFormHijo(new Grupos(), this.panelContenedor);
           
            lbl_topPanel.Text = "GRUPOS";
            panelTop.BackColor = Color.FromArgb(108, 179, 81);
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
            btn_instrucciones.BackColor = Color.FromArgb(230, 193, 100);
        }

        private void btn_agregar_MouseLeave(object sender, EventArgs e)
        {
            btn_instrucciones.BackColor = Color.FromArgb(33, 39, 52);
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("hh:mm");
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        void autocompletar()
        {
            AutoCompleteStringCollection listaDeOpciones = new AutoCompleteStringCollection();
            listaDeOpciones.Add("Alumnos");
            listaDeOpciones.Add("Agregar Alumno");
            listaDeOpciones.Add("Docentes");
            listaDeOpciones.Add("Agregar Docente");
            listaDeOpciones.Add("Grupos");
            listaDeOpciones.Add("Agregar Grupo");
            
            txt_busc.AutoCompleteCustomSource = listaDeOpciones;
            
           
        }

        private void txt_buscador_Click(object sender, EventArgs e)
        {

            
        }

        private void txt_buscador_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
           
         
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscador_Click(object sender, EventArgs e)
        {
            if(txt_busc.Text == "Agregar Alumno")
            {
                panelContenedor.Controls.Clear();
                Metodos.AbrirFormHijo(new Alumnos(), this.panelContenedor);

                AlumnosAgregar f2 = new AlumnosAgregar();
                f2.ShowDialog();

                lbl_topPanel.Text = "ALUMNOS";
                panelTop.BackColor = Color.FromArgb(87, 173, 221);
            }
            else if(txt_busc.Text == "Alumnos")
            {
                panelContenedor.Controls.Clear();
                Metodos.AbrirFormHijo(new Alumnos(), this.panelContenedor);

                lbl_topPanel.Text = "ALUMNOS";
                panelTop.BackColor = Color.FromArgb(87, 173, 221);

            }
        }

        private void pictureBox_UsuarioSel_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            lbl_topPanel.Text = "INICIO";
            panelTop.BackColor = Color.FromArgb(78, 54, 103);

        }

        private void txt_busc_Enter(object sender, EventArgs e)
        {
            txt_busc.Text = "";
        }

        private void btn_talleres_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Metodos.AbrirFormHijo(new Talleres(), this.panelContenedor);


            lbl_topPanel.Text = "TALLERES";
            panelTop.BackColor = Color.FromArgb(192, 104, 168);
        }

        private void btn_talleres_MouseEnter(object sender, EventArgs e)
        {
            btn_talleres.BackColor = Color.FromArgb(192, 104, 168);
            
        }

        private void btn_talleres_MouseLeave(object sender, EventArgs e)
        {
            btn_talleres.BackColor = Color.FromArgb(33, 39, 52);
        }
    }
}
