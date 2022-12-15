using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetodosColeg;
using ClaseVariables;

namespace Colegio5
{
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
            if (Variables.user2)
            {
                btn_crearGrupo.Enabled = false;
                btn_crearGrupo.Visible = false;
                btn_buscar.Location = new Point (406, 14);
            }
        }

  

        private void btn_crearGrupo_Click(object sender, EventArgs e)
        {
            Metodos.AbrirFormHijo(new GrupoAgregar(), this.panelPrincipal);
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Metodos.AbrirFormHijo(new GruposBuscar(), this.panelPrincipal);
           
        }
    }
}
