using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MetodosColeg;
using ClaseVariables;

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

        private void listV_Grupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.obtenerCodigo = listV_Grupos.SelectedItems[0].SubItems[0].Text;

            GruposVer gv = new GruposVer();
            gv.ShowDialog();
        }

        private void btn_buscarGrupos_Click(object sender, EventArgs e)
        {
            listV_Grupos.Items.Clear();

            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            string mostrarGrupos = "SELECT Grupo.CodGrupo, Persona.Apellido, Persona.Nombre, Caracterizacion.Especificacion, Grupo.CantidadAlumnos, Ciclo.Ciclos, Grupo.FechaAlta, Grupo.Turno" +
                                   " FROM Ciclo INNER JOIN(Caracterizacion INNER JOIN(Persona INNER JOIN(Docente INNER JOIN Grupo ON Docente.DNIDocente = Grupo.DNIDocente) ON Persona.DNI = Docente.DNIDocente) ON(Caracterizacion.CodCaracterizacion = Grupo.codCaract) AND(Caracterizacion.CodCaracterizacion = Docente.CodCaracterizacion)) ON Ciclo.CodCiclo = Grupo.CodigoCiclo " +
                                   " WHERE Grupo.CodGrupo = " + txt_buscarGrupo.Text + ";";

            Variables.Orden = new OleDbCommand(mostrarGrupos, Variables.ConexionConBD);
            Variables.Lector = Variables.Orden.ExecuteReader();

            while (Variables.Lector.Read())
            {
                ListViewItem lvitem = new ListViewItem(Variables.Lector["CodGrupo"].ToString());
                lvitem.SubItems.Add(Variables.Lector["Apellido"].ToString());
                lvitem.SubItems.Add(Variables.Lector["Nombre"].ToString());
                lvitem.SubItems.Add(Variables.Lector["Especificacion"].ToString());
                lvitem.SubItems.Add(Variables.Lector["CantidadAlumnos"].ToString());
                lvitem.SubItems.Add(Variables.Lector["Ciclos"].ToString());
                lvitem.SubItems.Add(Variables.Lector["FechaAlta"].ToString());
                lvitem.SubItems.Add(Variables.Lector["Turno"].ToString());
                listV_Grupos.Items.Add(lvitem);
            }
            listV_Grupos.Refresh();
            Variables.Lector.Close();
            Variables.ConexionConBD.Close();
        }
    }
}
