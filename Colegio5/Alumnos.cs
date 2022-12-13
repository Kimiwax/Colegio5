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
using ClaseVariables;



namespace Colegio5
{
    public partial class Alumnos : Form
    {
        public Alumnos()
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
            //AlumnoAgregarAdulto f2 = new AlumnoAgregarAdulto();
            AlumnosAgregar f2 = new AlumnosAgregar();
            f2.ShowDialog();

            dgv_alumnos.Rows.Clear();
            Cargar_Grilla();
          
        }

        public void Cargar_Grilla()
        {
            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            string consultaInicial = "SELECT Alumno.DNIAlumno, Persona.Nombre, Persona.Apellido, Caracterizacion.Especificacion, Localidad.NomLocalidad, Persona.Direccion" +
                                       " FROM Caracterizacion INNER JOIN((Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones" +
                                       " WHERE Alumno.Habilitado = " + 1 + ";";
            Variables.Orden = new OleDbCommand(consultaInicial, Variables.ConexionConBD);
            Variables.Lector = Variables.Orden.ExecuteReader();

            while (Variables.Lector.Read())
            {
                dgv_alumnos.Rows.Add();
                dgv_alumnos[0, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["DNIAlumno"];
                dgv_alumnos[1, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["Nombre"];
                dgv_alumnos[2, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["Apellido"];
                dgv_alumnos[3, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["Especificacion"];
                dgv_alumnos[4, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["NomLocalidad"];
                dgv_alumnos[5, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["Direccion"];
            }
            dgv_alumnos.ClearSelection();
            Variables.Lector.Close();
            Variables.ConexionConBD.Close();
        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if(txt_buscarDni.Text != "")
            {
                dgv_alumnos.DataSource = null;
                dgv_alumnos.Rows.Clear();

                Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                Variables.ConexionConBD.Open();

                string consulta2 = "SELECT Alumno.DNIAlumno, Persona.Nombre, Persona.Apellido, Caracterizacion.Especificacion, Localidad.NomLocalidad, Persona.Direccion" +
                                   " FROM Caracterizacion INNER JOIN((Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones" +
                                   " WHERE Alumno.DNIAlumno = " + txt_buscarDni.Text + ";";

                string consulta = " SELECT Alumno.DNIAlumno, Persona.Apellido, Persona.Nombre, Persona.Direccion, Caracterizacion.Especificacion, Localidad.NomLocalidad" +
                                " FROM((((Alumno INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) INNER JOIN Caracterizacion ON AlumnoCaracterizaciones.CodigoCaracterizaciones = Caracterizacion.CodCaracterizacion) INNER JOIN Persona ON Alumno.DNIAlumno = Persona.DNI) INNER JOIN Localidad ON Persona.CodigoPostal = Localidad.CP)" +
                                " WHERE Alumno.DNIAlumno =" + txt_buscarDni.Text + ";";

                Variables.Orden = new OleDbCommand(consulta2, Variables.ConexionConBD);
                Variables.Lector = Variables.Orden.ExecuteReader();



                while (Variables.Lector.Read())
                {
                    dgv_alumnos.Rows.Add();
                    dgv_alumnos[0, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["DNIAlumno"];
                    dgv_alumnos[1, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["Nombre"];
                    dgv_alumnos[2, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["Apellido"];
                    dgv_alumnos[3, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["Especificacion"];
                    dgv_alumnos[4, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["NomLocalidad"];
                    dgv_alumnos[5, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["Direccion"];
                }
                dgv_alumnos.ClearSelection();
                Variables.Lector.Close();
                Variables.ConexionConBD.Close();
            }
            else
            {

            }
            



        }

        private void dgv_alumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == (-1))
            {

            }
            else
            {
                Variables.Row = e.RowIndex;
                Variables.GuardarDniAlumno = Convert.ToInt32(dgv_alumnos.Rows[Variables.Row].Cells[0].Value);
                Variables.guardarNomAlumno = Convert.ToString(dgv_alumnos.Rows[Variables.Row].Cells[1].Value);
                Variables.GuardarApeAlumno = Convert.ToString(dgv_alumnos.Rows[Variables.Row].Cells[2].Value);

                AlumnoModificar f3 = new AlumnoModificar(Variables.GuardarDniAlumno, Variables.guardarNomAlumno, Variables.GuardarApeAlumno);
                f3.FormClosed += new System.Windows.Forms.FormClosedEventHandler(f3_FormClosed);
                f3.ShowDialog();
            }
            
        }

        private void f3_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgv_alumnos.DataSource = null;
            dgv_alumnos.Rows.Clear();
            Cargar_Grilla();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            Cargar_Grilla();
        }


        private void dgv_alumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == (-1))
            {
                
            }
            else
            {
            }
        }

        private void cmb_filtros_SelectedValueChanged(object sender, EventArgs e)
        {
            dgv_alumnos.DataSource = null;
            dgv_alumnos.Rows.Clear();

            if (cmb_filtros.Text == "Alumnos de Baja")
            {
                Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                Variables.ConexionConBD.Open();

                string consulta2 = "SELECT Alumno.DNIAlumno, Persona.Nombre, Persona.Apellido, Caracterizacion.Especificacion, Localidad.NomLocalidad, Persona.Direccion" +
                                       " FROM Caracterizacion INNER JOIN((Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones" +
                                       " WHERE Alumno.Habilitado = " + 0 + ";";

                Variables.Orden = new OleDbCommand(consulta2, Variables.ConexionConBD);
                Variables.Lector = Variables.Orden.ExecuteReader();

                while (Variables.Lector.Read())
                {
                    dgv_alumnos.Rows.Add();
                    dgv_alumnos[0, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["DNIAlumno"];
                    dgv_alumnos[1, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["Nombre"];
                    dgv_alumnos[2, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["Apellido"];
                    dgv_alumnos[3, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["Especificacion"];
                    dgv_alumnos[4, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["NomLocalidad"];
                    dgv_alumnos[5, dgv_alumnos.Rows.Count - 1].Value = Variables.Lector["Direccion"];
                }
                dgv_alumnos.ClearSelection();

                Variables.Lector.Close();
                Variables.ConexionConBD.Close();
            }
            else if (cmb_filtros.Text == "Todos")
            {
                Cargar_Grilla();
            }
        }

        private void dgv_alumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
