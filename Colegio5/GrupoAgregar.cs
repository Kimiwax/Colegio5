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
    public partial class GrupoAgregar : Form
    {
        public GrupoAgregar()
        {
            InitializeComponent();
          
           
        }

        private void carga_cmbCaracterizacion()
        {
            string consulta5 = "Select CodCaracterizacion, Especificacion from Caracterizacion;";
            Variables.Lector = Metodos.LecturaDB(consulta5);
            DataTable dsCombo5 = new DataTable();
            dsCombo5.Load(Variables.Lector);
            cmb_caracterizacionAMod.DataSource = dsCombo5;
            cmb_caracterizacionAMod.DisplayMember = "Especificacion";
            cmb_caracterizacionAMod.ValueMember = "CodCaracterizacion";
            Variables.Lector.Close();
        }

        private void carga_cmbCiclo()
        {
            string consulta6 = "Select CodCiclo, Ciclo from Ciclo;";
            Variables.Lector = Metodos.LecturaDB(consulta6);
            DataTable dsCombo7 = new DataTable();
            dsCombo7.Load(Variables.Lector);
            cmb_CicloGrup.DataSource = dsCombo7;
            cmb_CicloGrup.DisplayMember = "Ciclo";
            cmb_CicloGrup.ValueMember = "CodCiclo";
            Variables.Lector.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgv_Grupo.Rows[e.RowIndex].Cells[3].Value.ToString() == "Docente")
            {
                lstBox_Docente.Items.Add(dgv_Grupo.Rows[e.RowIndex].Cells[1].Value.ToString() + "  " + dgv_Grupo.Rows[e.RowIndex].Cells[2].Value.ToString());
                Variables.nomApeDocente = dgv_Grupo.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dgv_Grupo.Rows[e.RowIndex].Cells[2].Value.ToString();
                Variables.guardarDniDocente = Convert.ToInt32(dgv_Grupo.Rows[e.RowIndex].Cells[0].Value);

            }
            else if (dgv_Grupo.Rows[e.RowIndex].Cells[3].Value.ToString() == "Alumno"){
                lstBox_Alumnos.Items.Add(dgv_Grupo.Rows[e.RowIndex].Cells[1].Value.ToString() + "  " + dgv_Grupo.Rows[e.RowIndex].Cells[2].Value.ToString());
                Variables.GuardarNomApeAlumnos.Add(dgv_Grupo.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dgv_Grupo.Rows[e.RowIndex].Cells[2].Value.ToString());
                Variables.GuardarDocumentos.Add(Convert.ToInt32(dgv_Grupo.Rows[e.RowIndex].Cells[0].Value));
            }
            dgv_Grupo.Rows.RemoveAt(dgv_Grupo.CurrentRow.Index);
        }

        
        private void btn_crearGrupo_Click_1(object sender, EventArgs e)
        {
            Variables.codigoGrupo = txt_nombreGrupo.Text;

            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            string date = DateTime.Now.ToString("MM-dd-yyyy");

            string insertGrupo = "INSERT INTO Grupo (CodGrupo, DNIDocente, codCaract, CodigoCiclo, FechaAlta, Turno, CantidadAlumnos) Values (" + txt_nombreGrupo.Text + "," + Variables.guardarDniDocente + "," + Variables.selecCaracterizacion + "," + Variables.selecCiclo + ",'" + date + "','" + cmb_turno.Text + "'," + Variables.GuardarDocumentos.Count + ");";
            Variables.Orden = new OleDbCommand(insertGrupo, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            for (int i = 0; i < Variables.GuardarDocumentos.Count; i++)
            {
                Variables.guardarAlumnGrupo = Variables.GuardarDocumentos[i];
                string insertGrupoAlumno = "INSERT INTO GrupoAlumno (CodGrupo, DNIAlumno) Values (" + txt_nombreGrupo.Text + "," + Variables.guardarAlumnGrupo + ");";
                Variables.Orden = new OleDbCommand(insertGrupoAlumno, Variables.ConexionConBD);
                Variables.Orden.ExecuteNonQuery();
            }

            Form okcan = new ShowDialogGrupos();

            DialogResult Result = okcan.ShowDialog();

            if (Result == DialogResult.OK)
            {
                MessageBox.Show("Se creo correctamente el grupo", "Aviso");
            }
            else { }
            //btn_crearGrupo.Text = "Cancel";
        }

        private void GrupoAgregar_Load(object sender, EventArgs e)
        {
            carga_cmbCaracterizacion();
            carga_cmbCiclo();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgv_Grupo.Rows.Clear();

            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            string traerAlumno = "SELECT AlumnoCaracterizaciones.dniAlumno, Persona.Nombre, Persona.Apellido" +
                " FROM Persona INNER JOIN(Alumno INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Persona.DNI = Alumno.DNIAlumno" +
                " WHERE AlumnoCaracterizaciones.CodigoCaracterizaciones = " + Variables.selecCaracterizacion + ";";

            Variables.Orden = new OleDbCommand(traerAlumno, Variables.ConexionConBD);
            Variables.Lector = Variables.Orden.ExecuteReader();

            while (Variables.Lector.Read())
            {
                dgv_Grupo.Rows.Add();
                dgv_Grupo[0, dgv_Grupo.Rows.Count - 1].Value = Variables.Lector["dniAlumno"];
                dgv_Grupo[1, dgv_Grupo.Rows.Count - 1].Value = Variables.Lector["Nombre"];
                dgv_Grupo[2, dgv_Grupo.Rows.Count - 1].Value = Variables.Lector["Apellido"];
                dgv_Grupo[3, dgv_Grupo.Rows.Count - 1].Value = "Alumno";
            }
            dgv_Grupo.ClearSelection();

            string traerDocente = "SELECT Docente.DNIDocente, Persona.Nombre, Persona.Apellido" +
                " FROM Persona INNER JOIN Docente ON Persona.DNI = Docente.DNIDocente" +
                " WHERE Docente.CodCaracterizacion = " + Variables.selecCaracterizacion + ";";

            Variables.Orden = new OleDbCommand(traerDocente, Variables.ConexionConBD);
            Variables.Lector = Variables.Orden.ExecuteReader();

            while (Variables.Lector.Read())
            {
                dgv_Grupo.Rows.Add();
                dgv_Grupo[0, dgv_Grupo.Rows.Count - 1].Value = Variables.Lector["DNIDocente"];
                dgv_Grupo[1, dgv_Grupo.Rows.Count - 1].Value = Variables.Lector["Nombre"];
                dgv_Grupo[2, dgv_Grupo.Rows.Count - 1].Value = Variables.Lector["Apellido"];
                dgv_Grupo[3, dgv_Grupo.Rows.Count - 1].Value = "Docente";
            }
            dgv_Grupo.ClearSelection();
            Variables.Lector.Close();
            Variables.ConexionConBD.Close();
        }

        private void cmb_caracterizacionAMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.selecCaracterizacion = Convert.ToString(cmb_caracterizacionAMod.SelectedValue);
        }

        private void cmb_CicloGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.selecCiclo = Convert.ToString(cmb_CicloGrup.SelectedValue);
        }
    }
}
