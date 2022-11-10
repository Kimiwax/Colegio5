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

        

       

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
