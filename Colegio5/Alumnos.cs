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
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("20-45101756-5", "Agustin", "Larroca", "-", "Guernica", "Oroño 234", 1123531287);
            dataGridView1.Rows.Add("20-46591747-5", "Alejandro", "Lopez", "-", "Glew", "Roca 1324", 1134324927);
            dataGridView1.Rows.Add("20-43641756-5", "Camila", "Caio", "-", "A.Korn", "Segui 1325", 1123531287);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AlumnosAgregar f2 = new AlumnosAgregar();
            f2.Show();
            
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
