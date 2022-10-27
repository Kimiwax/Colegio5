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
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
        }

        public void abrirFormHijo(object formHijo)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }

        private void btn_crearGrupo_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new GrupoAgregar());
        }
    }
}
