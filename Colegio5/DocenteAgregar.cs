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
using MetodosColeg;
using System.Text.RegularExpressions;

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
            cmb_caracterizacionD.Text = "";
            cmb_localidadD.Text = "";
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
            if (IsValidate())
            {
                errorDoc.Clear();
                Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                Variables.ConexionConBD.Open();

                string FechaNacimientoD = dtp_fechadenacD.Value.ToString("dd/MM/yyyy");


                string insertPersona = "INSERT INTO Persona (DNI, Nombre, Apellido, FechaNac, Sexo, Direccion, CodigoPostal) Values (" + txt_dniD.Text + ", '" + txt_nombreD.Text + "','" + txt_apellidoD.Text + "','" + FechaNacimientoD + "','" + cmb_sexoD.Text + "','" + txt_direccionD.Text + "'," + Variables.selecLocalidad + ");";
               // string insertDocente = "INSERT INTO Docente (DNIDocente, Legajo, Mail, CodCaracterizacion, Habilitado) Values (" + txt_dniD.Text + ",'" + txt_legajoD.Text + "','" + txt_emailD.Text + "'," + Variables.selecCaracterizacion + "," + 1 + ");";
                string insertDocente = "INSERT INTO Docente (DNIDocente, Legajo, Mail, CodCaracterizacion, Habilitado, Grupo) Values (" + txt_dniD.Text + ",'" + txt_legajoD.Text + "','" + txt_emailD.Text + "'," + Variables.selecCaracterizacion + "," + 1 + "," + 1 + ");";
                string insertTelefono = "INSERT INTO Telefono(DniPersona, NumTel) values (" + txt_dniD.Text + "," + txt_telefonoD.Text + ");";

                Variables.Orden = new OleDbCommand(insertPersona, Variables.ConexionConBD);
                Variables.Orden.ExecuteNonQuery();

                Variables.Orden = new OleDbCommand(insertDocente, Variables.ConexionConBD);
                Variables.Orden.ExecuteNonQuery();

                Variables.Orden = new OleDbCommand(insertTelefono, Variables.ConexionConBD);
                Variables.Orden.ExecuteNonQuery();

                Variables.ConexionConBD.Close();

                MessageBox.Show("Docente cargado Correctamente");
                this.Close();

            }
                
        }

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_caracterizacionD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.selecCaracterizacion = Convert.ToString(cmb_caracterizacionD.SelectedValue);
        }

        private void cmb_localidadD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.selecLocalidad = Convert.ToString(cmb_localidadD.SelectedValue);
        }

        private bool IsValidate()
        {
            bool noError = true;
            
            if (string.IsNullOrEmpty(txt_nombreD.Text))
            {
                errorDoc.SetError(txt_nombreD, "Ingrese NOMBRE del Docente ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_apellidoD.Text))
            {
                errorDoc.Clear();
                errorDoc.SetError(txt_apellidoD, "Ingrese APELLIDO del Docente ");
                noError = false;
            }
            else if (DateTime.Now.Subtract(dtp_fechadenacD.Value.Date).Days < 10)
            {
                errorDoc.Clear();
                errorDoc.SetError(dtp_fechadenacD, "Ingrese una fecha correcta ");
                noError = false;
            }
            else if (cmb_sexoD.SelectedIndex == -1)
            {
                errorDoc.Clear();
                errorDoc.SetError(cmb_sexoD, "Seleccione SEXO del Docente ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_dniD.Text) || txt_dniD.Text.Length < 6)
            {
                errorDoc.Clear();
                errorDoc.SetError(txt_dniD, "Ingrese DNI del Docente ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_legajoD.Text))
            {
                errorDoc.Clear();
                errorDoc.SetError(txt_legajoD, "Ingrese LEGAJO del Docente ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_telefonoD.Text))
            {
                errorDoc.Clear();
                errorDoc.SetError(txt_telefonoD, "Ingrese TELÉFONO del Docente ");
                noError = false;
            }
            else if (cmb_caracterizacionD.SelectedIndex == -1)
            {
                errorDoc.Clear();
                errorDoc.SetError(cmb_caracterizacionD, "Seleccione a que grupo de CARACTERIZACIÓN pertenece el Docente ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_emailD.Text))
            {
                errorDoc.Clear();
                errorDoc.SetError(txt_emailD, "Ingrese CORREO ELECTRONICO del Docente ");
                noError = false;
            }
            else if(!(Regex.IsMatch(txt_emailD.Text, regexMail)))
            {
                errorDoc.Clear();
                errorDoc.SetError(txt_emailD, "Correo electronico invalido ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_direccionD.Text))
            {
                errorDoc.Clear();
                errorDoc.SetError(txt_direccionD, "Ingrese DOMICILIO del Docente ");
                noError = false;
            }
            else if (cmb_localidadD.SelectedIndex == -1)
            {
                errorDoc.Clear();
                errorDoc.SetError(cmb_localidadD, "Ingrese LOCALIDAD del Docente ");
                noError = false;
            }

            return noError;
        }

        private void txt_nombreD_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosColeg.Metodos.ValidarLetras(e);
        }

        private void txt_apellidoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(e);
        }

        private void txt_dniD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNumeros(e);
        }

        private void txt_legajoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNumeros(e);
        }

        private void txt_telefonoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNumeros(e);
        }
        String regexMail = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";
        private void txt_emailD_KeyPress(object sender, KeyPressEventArgs e)
        {

            Metodos.Validaremail(e);
        }

        private void txt_direccionD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarSoloNumerosYLetras(e);
        }
    }
}
