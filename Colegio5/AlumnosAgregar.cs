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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            string pepe = dtp_fechadenacA.Value.ToString("dd/MM/yyyy");

            string insertPersona = "INSERT INTO Persona (DNI, Nombre, Apellido, FechaNac, Sexo, Direccion, CodigoPostal) Values ('" + txt_dniA.Text + "', '" + txt_nombreA.Text + "','" + txt_apellidoA.Text + "','" + pepe + "','" + cmb_sexoA.Text + "','" + txt_domicilioA.Text + "'," + 1865 + ");" ;
            string insertAlumno = "INSERT INTO Alumno (DNIAlumno, ObraSocial, CUD) Values ('" + txt_dniA.Text + "','" + txt_obrasocialA.Text + "','" + cmb_pensionA.Text + "');";
            string insertCaracterizacion = "INSERT INTO Caracterizacion (Especificacion) Values ('" + cmb_caracterizacionA.Text + "');";
            string insertLocalidad = "INSERT INTO Localidad (NomLoca" +
                "lidad) Values ('" + txt_localidadA.Text + "');";

            Variables.Orden = new OleDbCommand(insertPersona, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            Variables.Orden = new OleDbCommand(insertAlumno, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            Variables.Orden = new OleDbCommand(insertCaracterizacion, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            Variables.Orden = new OleDbCommand(insertLocalidad, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            Variables.ConexionConBD.Close();


            //AlumnoAgregarAdulto f3 = new AlumnoAgregarAdulto();
            //f3.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
