using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseVariables;
using MetodosColeg;
using System.Data.OleDb;


namespace Colegio5
{
    public partial class Docentes : Form
    {
        public Docentes()
        {
            InitializeComponent();
            if (Variables.user2)
            {
                button2.Enabled = false;
                button2.Visible = false;
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DocenteAgregar f1 = new DocenteAgregar();
            f1.ShowDialog();
            dgv_Docentes.Rows.Clear();
            CargarGrilla();
            
        }

        private void dgv_Docentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == (-1))
            {

            }
            else
            {

                Variables.Row = e.RowIndex;
                Variables.GuardarDniDocente = Convert.ToInt32(dgv_Docentes.Rows[Variables.Row].Cells[0].Value);
                Variables.GuardarNomDocente = Convert.ToString(dgv_Docentes.Rows[Variables.Row].Cells[1].Value);
                Variables.GuardarApeDocente = Convert.ToString(dgv_Docentes.Rows[Variables.Row].Cells[2].Value);
                DocentesModificar f3 = new DocentesModificar(Variables.GuardarDniDocente, Variables.GuardarNomDocente, Variables.GuardarApeDocente);
                f3.FormClosed += new System.Windows.Forms.FormClosedEventHandler(f3_FormClosed);
                f3.ShowDialog();
             
            }

        }

        private void f3_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgv_Docentes.DataSource = null;
            dgv_Docentes.Rows.Clear();
            CargarGrilla();
        }

        private void Docentes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    

    public void CargarGrilla()
        {
            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            string consultaInicial = "SELECT Docente.DNIDocente, Persona.Nombre, Persona.Apellido, Localidad.NomLocalidad, Persona.Direccion" +
                                       " FROM Localidad INNER JOIN (Persona INNER JOIN Docente ON Persona.DNI = Docente.DNIDocente) ON Localidad.CP = Persona.CodigoPostal" +
                                       " WHERE Docente.Habilitado = " + 1 + ";";

            Variables.Orden = new OleDbCommand(consultaInicial, Variables.ConexionConBD);
            Variables.Lector = Variables.Orden.ExecuteReader();

            while (Variables.Lector.Read())
            {
                dgv_Docentes.Rows.Add();
                dgv_Docentes[0, dgv_Docentes.Rows.Count - 1].Value = Variables.Lector["DNIDocente"];
                dgv_Docentes[1, dgv_Docentes.Rows.Count - 1].Value = Variables.Lector["Nombre"];
                dgv_Docentes[2, dgv_Docentes.Rows.Count - 1].Value = Variables.Lector["Apellido"];
                dgv_Docentes[3, dgv_Docentes.Rows.Count - 1].Value = Variables.Lector["NomLocalidad"];
                dgv_Docentes[4, dgv_Docentes.Rows.Count - 1].Value = Variables.Lector["Direccion"];
            }
            dgv_Docentes.ClearSelection();
            Variables.Lector.Close();
            Variables.ConexionConBD.Close();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_Docentes.DataSource = null;
            dgv_Docentes.Rows.Clear();
        }

        private void cmb_filtrosDoc_SelectedValueChanged(object sender, EventArgs e)
        {
            dgv_Docentes.DataSource = null;
            dgv_Docentes.Rows.Clear();

            if(cmb_filtrosDoc.Text == "Docentes de Baja")
            {
                Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                Variables.ConexionConBD.Open();

                string consultaInicial = "SELECT Docente.DNIDocente, Persona.Nombre, Persona.Apellido, Localidad.NomLocalidad, Persona.Direccion" +
                                           " FROM Localidad INNER JOIN (Persona INNER JOIN Docente ON Persona.DNI = Docente.DNIDocente) ON Localidad.CP = Persona.CodigoPostal" +
                                           " WHERE Docente.Habilitado = " + 0 + ";";

                Variables.Orden = new OleDbCommand(consultaInicial, Variables.ConexionConBD);
                Variables.Lector = Variables.Orden.ExecuteReader();

                while (Variables.Lector.Read())
                {
                    dgv_Docentes.Rows.Add();
                    dgv_Docentes[0, dgv_Docentes.Rows.Count - 1].Value = Variables.Lector["DNIDocente"];
                    dgv_Docentes[1, dgv_Docentes.Rows.Count - 1].Value = Variables.Lector["Nombre"];
                    dgv_Docentes[2, dgv_Docentes.Rows.Count - 1].Value = Variables.Lector["Apellido"];
                    dgv_Docentes[3, dgv_Docentes.Rows.Count - 1].Value = Variables.Lector["NomLocalidad"];
                    dgv_Docentes[4, dgv_Docentes.Rows.Count - 1].Value = Variables.Lector["Direccion"];
                }
                dgv_Docentes.ClearSelection();
                Variables.Lector.Close();
                Variables.ConexionConBD.Close();
            }
            else if (cmb_filtrosDoc.Text == "Todos")
            {
                dgv_Docentes.DataSource = null;
                dgv_Docentes.Rows.Clear();
                CargarGrilla();
            }
        }
    }
}
