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
    public partial class DocenteAgregar : Form
    {
        public DocenteAgregar()
        {
            InitializeComponent();
        }

        private void DocenteAgregar_Load(object sender, EventArgs e)
        {
            carga_cmbLocalidad();
            carga_cmbCaracterizacion();
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
            string consulta2 = "Select CP, NomLocalidad from Localidad;";
            Variables.Lector = LecturaDB(consulta2);
            DataTable dsCombo = new DataTable();//Creo el objeto de tipo datatable para que reciba los registros del lector
            dsCombo.Load(Variables.Lector);
            cmb_localidadD.DataSource = dsCombo;
            cmb_localidadD.DisplayMember = "NomLocalidad";//Muestro el nombre de localidad al usuario
            cmb_localidadD.ValueMember = "CP";//Tomo el valor de codigo postal de la localidad
            Variables.Lector.Close();
        }



        private void carga_cmbCaracterizacion()
        {
            string consulta2 = "Select CodCaracterizacion, Especificacion from Caracterizacion;";
            Variables.Lector = LecturaDB(consulta2);
            DataTable dsCombo2 = new DataTable();//Creo el objeto de tipo datatable para que reciba los registros del lector
            dsCombo2.Load(Variables.Lector);
            cmb_caracterizacionD.DataSource = dsCombo2;
            cmb_caracterizacionD.DisplayMember = "Especificacion";//Muestro el nombre de localidad al usuario
            cmb_caracterizacionD.ValueMember = "CodCaracterizacion";//Tomo el valor de codigo postal de la localidad
            Variables.Lector.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            string FechaNacimientoD = dtp_fechadenacD.Value.ToString("dd/MM/yyyy");
            

            string insertPersona = "INSERT INTO Persona (DNI, Nombre, Apellido, FechaNac, Sexo, Direccion, CodigoPostal) Values (" + txt_dniD.Text + ", '" + txt_nombreD.Text + "','" + txt_apellidoD.Text + "','" + FechaNacimientoD + "','" + cmb_sexoD.Text + "','" + txt_direccionD.Text + "'," + cmb_localidadD.ValueMember + ");";
            string insertDocente = "INSERT INTO Docente (DNIDocente, Legajo, Mail, CodCaracterizacion) Values (" + txt_dniD.Text + ",'" + txt_legajoD.Text + "','" + txt_emailD.Text + "','" + cmb_caracterizacionD.ValueMember + ");";

            Variables.Orden = new OleDbCommand(insertPersona, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            Variables.Orden = new OleDbCommand(insertDocente, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            Variables.ConexionConBD.Close();
            this.Close();
        }

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
