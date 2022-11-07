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
    public partial class Docentes : Form
    {
        public Docentes()
        {
            InitializeComponent();
            dgv_Docentes.Rows.Add("20-39101756-5", "Liliana", "Basile", "-", "Guernica", "Sta Ana 154", 1148184287);
            dgv_Docentes.Rows.Add("20-37591747-5", "Martin", "Vega", "-", "Longchamps", "Pampa 3454", 1146224927);
            dgv_Docentes.Rows.Add("20-41641756-5", "Gabriela", "Barbero", "-", "A.Korn", "Salta 2654", 1462546387);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DocenteAgregar f1 = new DocenteAgregar();
            f1.Show();

            
        }

        private void dgv_Docentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DocentesModificar f3 = new DocentesModificar();
            f3.Show();
        }
    }
}
