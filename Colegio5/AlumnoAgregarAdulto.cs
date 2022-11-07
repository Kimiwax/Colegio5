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
    public partial class AlumnoAgregarAdulto : Form
    {
        public AlumnoAgregarAdulto()
        {
            InitializeComponent();
        }
        static int contador = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            

            DialogResult Result = MessageBox.Show("¿Desea agregar otro familiar?", "Aviso", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {
                contador += 1;
                if(contador <= 2)
                {
                    AlumnoAgregarAdulto nuevoFamiliar = new AlumnoAgregarAdulto();
                    nuevoFamiliar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("no se pueden agregar mas familiares");
                }
                
            }
            else {
                MessageBox.Show("Se agrego correctamente al alumno");
            }
            contador = 0;
            //this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
