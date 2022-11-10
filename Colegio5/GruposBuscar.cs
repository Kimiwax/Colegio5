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
    public partial class GruposBuscar : Form
    {
        public GruposBuscar()
        {
            InitializeComponent();
            ListViewItem lvitem = new ListViewItem("423");
            lvitem.SubItems.Add("GRUPO 242");
            lvitem.SubItems.Add("Sandra Benitez");
            lvitem.SubItems.Add("TES");
            lvitem.SubItems.Add("3");
            listV_Grupos.Items.Add(lvitem);

        }

        private void dgv_alumnosG_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
               
            }
        }
 

        private void listV_Grupos_Click(object sender, EventArgs e)
        {
            GruposVer gv = new GruposVer();

            gv.ShowDialog();
        }
    }
}
