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
                //ContextMenuStrip menu =  new System.Windows.Forms.ContextMenuStrip();
                //int posicion = dgv_alumnosG.HitTest(e.X, e.Y).RowIndex;
                //if(posicion > -1)
                //{
                //    menu.Items.Add("Eliminar Del Registro").Name = "Eliminar" + posicion;
                //}
                //menu.Show(dgv_alumnosG, e.X, e.Y);
                //menu.ItemClicked += new ToolStripItemClickedEventHandler(menuClick);
            }
        }

        private void menuClick(object sender, ToolStripItemClickedEventArgs e)
        {
            string id = e.ClickedItem.Name.ToString();
            if(id.Contains("Eliminar"))
            {
                id = id.Replace("Eliminar", "");
                mostrar(Convert.ToInt32(id));
            }

        }

      

        private void mostrar(int idAMostrar)
        {
            //string res = "ID=" + dgv_alumnosG.Rows[idAMostrar].Cells[0].Value.ToString();
        }

        private void listV_Grupos_Click(object sender, EventArgs e)
        {
            GruposVer gv = new GruposVer();

            gv.ShowDialog();
        }
    }
}
