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
using System.Data.OleDb;

namespace Colegio5
{
    public partial class AlumnosAgregar : Form
    {
        public AlumnosAgregar()
        {
            InitializeComponent();
        }

        int valorSedInc;
        private void AlumnosAgregar_Load(object sender, EventArgs e)
        {
            
        }
        public static OleDbDataReader LecturaDB(string consulta)
        {
            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            Variables.Orden = new OleDbCommand(consulta, Variables.ConexionConBD);// orden = a la consulta de la base de datos de la conexion
            Variables.Lector = Variables.Orden.ExecuteReader();//Para select solamente, todo resultado de leer una BD devuelve una estructura
            return Variables.Lector;

            Variables.ConexionConBD.Close();
        }

        private void carga_cmbLocalidad()
        {
            string consulta3 = "Select CP, NomLocalidad from Localidad;";
            Variables.Lector = LecturaDB(consulta3);
            DataTable dsCombo = new DataTable();//Creo el objeto de tipo datatable para que reciba los registros del lector
            dsCombo.Load(Variables.Lector);
            cmb_localidadAlumno.DataSource = dsCombo;
            cmb_localidadAlumno.DisplayMember = "NomLocalidad";//Muestro el nombre de localidad al usuario
            cmb_localidadAlumno.ValueMember = "CP";//Tomo el valor de codigo postal de la localidad
            Variables.Lector.Close();
        }

        

        private void carga_cmbCaracterizacion()
        {
            string consulta2 = "Select CodCaracterizacion, Especificacion from Caracterizacion;";
            Variables.Lector = LecturaDB(consulta2);
            DataTable dsCombo2 = new DataTable();//Creo el objeto de tipo datatable para que reciba los registros del lector
            dsCombo2.Load(Variables.Lector);
            cmb_caracterizacionA.DataSource = dsCombo2;
            cmb_caracterizacionA.DisplayMember = "Especificacion";//Muestro el nombre de localidad al usuario
            cmb_caracterizacionA.ValueMember = "CodCaracterizacion";//Tomo el valor de codigo postal de la localidad
            Variables.Lector.Close();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmb_sedeinclusionA.SelectedItem.ToString() == "Sede")
            { valorSedInc = 1; }
            else
            { valorSedInc = 2; }

            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            string FechaNacimientoA = dtp_fechadenacA.Value.ToString("dd/MM/yyyy");
            string FechaingresoA = dtp_fechaIngresoA.Value.ToString("dd/MM/yyyy");

            string insertPersona = "INSERT INTO Persona (DNI, Nombre, Apellido, FechaNac, Sexo, Direccion, CodigoPostal) Values (" + txt_dniA.Text + ", '" + txt_nombreA.Text + "','" + txt_apellidoA.Text + "','" + FechaNacimientoA + "','" + cmb_sexoA.Text + "','" + txt_domicilioA.Text + "'," + Variables.selecLocalidad + ");";
            string insertAlumno = "INSERT INTO Alumno (DNIAlumno, ObraSocial, CUD, FechaIng, CodigoSedIncDom, Legajo) Values (" + txt_dniA.Text + ",'" + txt_obrasocialA.Text + "','" + cmb_pensionA.Text + "','" + FechaingresoA + "'," + valorSedInc + "," + txt_LegajoA.Text + ");";
            string insertAlumnoCaracterizacion = "INSERT INTO AlumnoCaracterizaciones (dniAlumno, CodigoCaracterizaciones) Values (" + txt_dniA.Text + ", " + Variables.selecCaracterizacion + ");";


            Variables.Orden = new OleDbCommand(insertPersona, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            Variables.Orden = new OleDbCommand(insertAlumno, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            Variables.Orden = new OleDbCommand(insertAlumnoCaracterizacion, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            Variables.ConexionConBD.Close();

            AlumnoAgregarAdulto f3 = new AlumnoAgregarAdulto();
            f3.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selecciona_localidad(object sender, EventArgs e)
        {
            Variables.selecLocalidad = Convert.ToString(cmb_localidadAlumno.SelectedValue);
        }

        private void AlumnosAgregar_Load_1(object sender, EventArgs e)
        {
            carga_cmbLocalidad();
            carga_cmbCaracterizacion();
        }

        private void Selecciona_Caracterizacion(object sender, EventArgs e)
        {
            Variables.selecCaracterizacion = Convert.ToString(cmb_caracterizacionA.SelectedValue);
        }
    }
}
