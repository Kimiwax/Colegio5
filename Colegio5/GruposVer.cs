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
    public partial class GruposVer : Form
    {
        public GruposVer()
        {
            InitializeComponent();
            ListViewItem lvitem = new ListViewItem("34435434");
            lvitem.SubItems.Add("Sandra");
            lvitem.SubItems.Add("Benitez");
            
            listV_docentes.Items.Add(lvitem);

            ListViewItem lvitem2 = new ListViewItem("45865743");
            lvitem2.SubItems.Add("Micaela");
            lvitem2.SubItems.Add("Pereyra");
            listV_alumnos.Items.Add(lvitem2);

            ListViewItem lvitem3 = new ListViewItem("46764562");
            lvitem3.SubItems.Add("Marcos");
            lvitem3.SubItems.Add("Cruz");
            listV_alumnos.Items.Add(lvitem3);

            ListViewItem lvitem4 = new ListViewItem("42567843");
            lvitem4.SubItems.Add("Abigail");
            lvitem4.SubItems.Add("Paz");
            listV_alumnos.Items.Add(lvitem4);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Especificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cmb_caracterizacionNA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cmb_cudA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_pensionA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txt_LegajoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_sedeinclusionA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cmb_localidadAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtp_fechaIngresoA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_sexoA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtp_fechadenacA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_domicilioA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_obrasocialA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txt_apellidoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_dniA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombreA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedorGrupos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
