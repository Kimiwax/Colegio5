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
            dgv_alumnos.Rows.Add("45101756", "Agustin", "Larroca", "TEL", "Guernica", "Oroño 234");
            dgv_alumnos.Rows.Add("46591747", "Alejandro", "Lopez", "TES", "Glew", "Roca 1324");
            dgv_alumnos.Rows.Add("43641756", "Camila", "Caio", "DV", "A.Korn", "Segui 1325");


  
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            AlumnosAgregar f2 = new AlumnosAgregar();
            f2.Show();
          
        }



        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //SELECT Alumno.DNIAlumno, Persona.Apellido, Persona.Nombre, Persona.Direccion, Caracterizacion.Especificacion, Localidad.NomLocalidad
            //FROM((((Alumno INNER JOIN
            //             AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) INNER JOIN
            //             Caracterizacion ON AlumnoCaracterizaciones.CodigoCaracterizaciones = Caracterizacion.CodCaracterizacion) INNER JOIN
            //             Persona ON Alumno.DNIAlumno = Persona.DNI) INNER JOIN
            //             Localidad ON Persona.CodigoPostal = Localidad.CP)
            //"SELECT Alumno.DNIAlumno, Persona.Nombre, Persona.Apellido, Caracterizacion.Especificacion, Localidad.NomLocalidad, Persona.Direccion" +
            //"FROM Caracterizacion INNER JOIN((Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones;";

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

            //DataTable dt = new DataTable();
            //dt.Load(Variables.Lector);
            //dgv_alumnos.DataSource = dt;

            //dgv_alumnos.ClearSelection();

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

        private void dgv_alumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.nombre = dgv_alumnos.Rows[e.RowIndex].Cells[1].Value.ToString();
            Variables.apellido = dgv_alumnos.Rows[e.RowIndex].Cells[2].Value.ToString();
            AlumnoModificar f3 = new AlumnoModificar();
            f3.Show();
        }
    }
}
