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
using MetodosColeg;

namespace Colegio5
{
    public partial class AlumnosAgregar : Form
    {
        public AlumnosAgregar()
        {
            InitializeComponent();
            
        }

        int valorSedInc;

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
            cmb_caracterizacionNA.DataSource = dsCombo2;
            cmb_caracterizacionNA.DisplayMember = "Especificacion";//Muestro el nombre de localidad al usuario
            cmb_caracterizacionNA.ValueMember = "CodCaracterizacion";//Tomo el valor de codigo postal de la localidad
            Variables.Lector.Close();
        }
        
       

        private bool IsValidate()
        {
            bool noError = true;
          
            if (string.IsNullOrEmpty(txt_nombreA.Text))
            {   
                errorIcono.SetError(txt_nombreA, "Ingrese NOMBRE del alumno ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_apellidoA.Text))
            {
                errorIcono.Clear();
                errorIcono.SetError(txt_apellidoA, "Ingrese APELLIDO del alumno ");
                noError = false;
            }
            else if (DateTime.Now.Subtract(dtp_fechadenacA.Value.Date).Days < 10)
            {
                errorIcono.Clear();
                errorIcono.SetError(dtp_fechadenacA, "Ingrese una fecha correcta ");
                noError = false;
            }
            else if(cmb_sexoA.SelectedIndex == -1)
            {
                errorIcono.Clear();
                errorIcono.SetError(cmb_sexoA, "Seleccione SEXO del alumno ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_dniA.Text) || txt_dniA.Text.Length < 8)
            {
                errorIcono.Clear();
                errorIcono.SetError(txt_dniA, "Ingrese DNI del alumno ");
                noError = false;
            }
            else if (cmb_caracterizacionNA.SelectedIndex == 0)
            {
                errorIcono.Clear();
                errorIcono.SetError(cmb_caracterizacionNA, "Seleccione CARACTERIZACIÓN del alumno ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_LegajoA.Text))
            {
                errorIcono.Clear();
                errorIcono.SetError(txt_LegajoA, "Ingrese LEGAJO del alumno ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_obrasocialA.Text))
            {
                errorIcono.Clear();
                errorIcono.SetError(txt_obrasocialA, "Ingrese OBRA SOCIAL del alumno ");
                noError = false;
            }
         
            else if (cmb_cudA.SelectedIndex == -1)
            {
                errorIcono.Clear();
                errorIcono.SetError(cmb_cudA, "Seleccione si el alumno tiene CUD ");
                noError = false;
            }
            else if (cmb_localidadAlumno.SelectedIndex == 0)
            {
                errorIcono.Clear();
                errorIcono.SetError(cmb_localidadAlumno, "Ingrese LOCALIDAD del alumno ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_domicilioA.Text))
            {
                errorIcono.Clear();
                errorIcono.SetError(txt_domicilioA, "Ingrese DOMICILIO del alumno ");
                noError = false;
            }
            else if (cmb_sedeinclusionA.SelectedIndex == -1)
            {
                errorIcono.Clear();
                errorIcono.SetError(cmb_sedeinclusionA, "Seleccione tipo de Serv del alumno ");
                noError = false;
            }
            return noError;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (IsValidate())
            {
                errorIcono.Clear();
                if (cmb_sedeinclusionA.SelectedItem.ToString() == "Sede")
                { valorSedInc = 1; }
                else
                { valorSedInc = 2; }

                Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                Variables.ConexionConBD.Open();

                string FechaNacimientoA = dtp_fechadenacA.Value.ToString("dd/MM/yyyy");
                string FechaingresoA = dtp_fechaIngresoA.Value.ToString("dd/MM/yyyy");

                string insertPersona = "INSERT INTO Persona (DNI, Nombre, Apellido, FechaNac, Sexo, Direccion, CodigoPostal) Values (" + txt_dniA.Text + ", '" + txt_nombreA.Text + "','" + txt_apellidoA.Text + "','" + FechaNacimientoA + "','" + cmb_sexoA.Text + "','" + txt_domicilioA.Text + "'," + Variables.selecLocalidad + ");";
                string insertAlumno = "INSERT INTO Alumno (DNIAlumno, ObraSocial, CUD, FechaIng, CodigoSedIncDom, Legajo, Especificacion, Habilitado) Values (" + txt_dniA.Text + ",'" + txt_obrasocialA.Text + "','" + Variables.seleccCud + "','" + FechaingresoA + "'," + valorSedInc + "," + txt_LegajoA.Text + ",'" + txt_Especificacion.Text + "'," + 1 + ");";
                string insertAlumnoCaracterizacion = "INSERT INTO AlumnoCaracterizaciones (dniAlumno, CodigoCaracterizaciones) Values (" + txt_dniA.Text + ", " + Variables.selecCaracterizacion + ");";

                Variables.guardarDNI = txt_dniA.Text;

                Variables.Orden = new OleDbCommand(insertPersona, Variables.ConexionConBD);
                Variables.Orden.ExecuteNonQuery();

                Variables.Orden = new OleDbCommand(insertAlumno, Variables.ConexionConBD);
                Variables.Orden.ExecuteNonQuery();

                Variables.Orden = new OleDbCommand(insertAlumnoCaracterizacion, Variables.ConexionConBD);
                Variables.Orden.ExecuteNonQuery();

                Variables.ConexionConBD.Close();

                AlumnoAgregarAdulto f3 = new AlumnoAgregarAdulto(Variables.guardarDNI);
                f3.ShowDialog();
                this.Close();
            }


               
        }

        

        private void selecciona_localidad(object sender, EventArgs e)
        {
            Variables.selecLocalidad = Convert.ToString(cmb_localidadAlumno.SelectedValue);
        }

        private void AlumnosAgregar_Load_1(object sender, EventArgs e)
        {
            carga_cmbLocalidad();
            carga_cmbCaracterizacion();
            cmb_localidadAlumno.Text = "";
            cmb_caracterizacionNA.Text = "";
            cmb_sedeinclusionA.Text = "";
            cmb_sexoA.Text = "";
            cmb_cudA.Text = "";
           
        }

        private void Selecciona_Caracterizacion(object sender, EventArgs e)
        {
            Variables.selecCaracterizacion = Convert.ToString(cmb_caracterizacionNA.SelectedValue);
        }

        private void btn_cerrarVentana1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nombreA_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosColeg.Metodos.ValidarLetras(e);
          
            
        }

        private void txt_apellidoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(e);
        }

        private void txt_dniA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNumeros(e);
        }

        private void txt_LegajoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNumeros(e);
        }

        private void txt_obrasocialA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(e);
        }

        private void txt_pensionA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(e);
        }

        private void txt_domicilioA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarSoloNumerosYLetras(e);
        }

        private void selecciona_cud(object sender, EventArgs e)
        {
            Variables.seleccCud = Convert.ToString(cmb_cudA.SelectedItem);
        }

    }
}
