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
    public partial class DocentesModificar : Form
    {
        public DocentesModificar(int Dni)
        {
            InitializeComponent();
            Variables.RecibirDniDocente = Dni;
        }

        private void tP_VerAlumno_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
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

        private void carga_cmbCaracterizacion()
        {
            string consulta2 = "Select CodCaracterizacion, Especificacion from Caracterizacion;";
            Variables.Lector = LecturaDB(consulta2);
            DataTable dsCombo2 = new DataTable();//Creo el objeto de tipo datatable para que reciba los registros del lector
            dsCombo2.Load(Variables.Lector);
            cmb_CaracterizacionModDoc.DataSource = dsCombo2;
            cmb_CaracterizacionModDoc.DisplayMember = "Especificacion";//Muestro el nombre de localidad al usuario
            cmb_CaracterizacionModDoc.ValueMember = "CodCaracterizacion";//Tomo el valor de codigo postal de la localidad
            Variables.Lector.Close();
        }

        private void carga_cmbLocalidad()
        {
            string consulta3 = "Select CP, NomLocalidad from Localidad;";
            Variables.Lector = LecturaDB(consulta3);
            DataTable dsCombo = new DataTable();//Creo el objeto de tipo datatable para que reciba los registros del lector
            dsCombo.Load(Variables.Lector);
            cmb_localidadD.DataSource = dsCombo;
            cmb_localidadD.DisplayMember = "NomLocalidad";//Muestro el nombre de localidad al usuario
            cmb_localidadD.ValueMember = "CP";//Tomo el valor de codigo postal de la localidad
            Variables.Lector.Close();
        }

        private void DocentesModificar_Load(object sender, EventArgs e)
        {
            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            string consultaDocente = "SELECT Persona.DNI, Persona.Apellido, Persona.Nombre, Persona.FechaNac, Persona.Sexo, Docente.Legajo, Telefono.NumTel, Caracterizacion.Especificacion, Docente.Mail, Persona.Direccion, Localidad.NomLocalidad" +
                                   " FROM Caracterizacion INNER JOIN(Localidad INNER JOIN ((Persona INNER JOIN Docente ON Persona.DNI = Docente.DNIDocente) INNER JOIN Telefono ON Persona.DNI = Telefono.DniPersona) ON Localidad.CP = Persona.CodigoPostal) ON Caracterizacion.CodCaracterizacion = Docente.CodCaracterizacion" +
                                   " WHERE Persona.DNI = " + Variables.RecibirDniDocente + ";";

            Variables.Orden = new OleDbCommand(consultaDocente, Variables.ConexionConBD);
            Variables.Lector = Variables.Orden.ExecuteReader();

            while (Variables.Lector.Read())
            {
                dgv_verDocentes.Rows.Add();
                dgv_verDocentes[0, dgv_verDocentes.Rows.Count - 1].Value = Variables.Lector["Nombre"];
                dgv_verDocentes[1, dgv_verDocentes.Rows.Count - 1].Value = Variables.Lector["Apellido"];
                dgv_verDocentes[2, dgv_verDocentes.Rows.Count - 1].Value = Variables.Lector["FechaNac"];
                dgv_verDocentes[3, dgv_verDocentes.Rows.Count - 1].Value = Variables.Lector["Sexo"];
                dgv_verDocentes[4, dgv_verDocentes.Rows.Count - 1].Value = Variables.Lector["DNI"];
                dgv_verDocentes[5, dgv_verDocentes.Rows.Count - 1].Value = Variables.Lector["Legajo"];
                dgv_verDocentes[6, dgv_verDocentes.Rows.Count - 1].Value = Variables.Lector["NumTel"];
                dgv_verDocentes[7, dgv_verDocentes.Rows.Count - 1].Value = Variables.Lector["Especificacion"];
                dgv_verDocentes[8, dgv_verDocentes.Rows.Count - 1].Value = Variables.Lector["Mail"];
                dgv_verDocentes[9, dgv_verDocentes.Rows.Count - 1].Value = Variables.Lector["Direccion"];
                dgv_verDocentes[10, dgv_verDocentes.Rows.Count - 1].Value = Variables.Lector["NomLocalidad"];
            }
            dgv_verDocentes.ClearSelection();

            txt_nombreD.Text = dgv_verDocentes.Rows[0].Cells[0].Value.ToString();
            txt_apellidoD.Text = dgv_verDocentes.Rows[0].Cells[1].Value.ToString();
            txt_FecNacD.Text = dgv_verDocentes.Rows[0].Cells[2].Value.ToString().Substring(0, 10);
            txt_SexoD.Text = dgv_verDocentes.Rows[0].Cells[3].Value.ToString();
            txt_dniD.Text = dgv_verDocentes.Rows[0].Cells[4].Value.ToString();
            txt_legajoD.Text = dgv_verDocentes.Rows[0].Cells[5].Value.ToString();
            txt_telefonoD.Text = dgv_verDocentes.Rows[0].Cells[6].Value.ToString();
            txt_caracterizacionD.Text = dgv_verDocentes.Rows[0].Cells[7].Value.ToString();
            txt_emailD.Text = dgv_verDocentes.Rows[0].Cells[8].Value.ToString();
            txt_direccionD.Text = dgv_verDocentes.Rows[0].Cells[9].Value.ToString();
            txt_localidadD.Text = dgv_verDocentes.Rows[0].Cells[10].Value.ToString();

            carga_cmbCaracterizacion();
            carga_cmbLocalidad();

            Variables.Lector.Close();
            Variables.ConexionConBD.Close();

            txt_nombreModDoc2.Text = dgv_verDocentes.Rows[0].Cells[0].Value.ToString();
            txt_apellidoModDoc2.Text = dgv_verDocentes.Rows[0].Cells[1].Value.ToString();
            dtp_FechaNacModDoc2.Text = dgv_verDocentes.Rows[0].Cells[2].Value.ToString();
            cmb_sexoModDoc2.Text = dgv_verDocentes.Rows[0].Cells[3].Value.ToString();
            txt_legajoModDoc2.Text = dgv_verDocentes.Rows[0].Cells[5].Value.ToString();
            txt_telefonoModDoc2.Text = dgv_verDocentes.Rows[0].Cells[6].Value.ToString();
            cmb_CaracterizacionModDoc.Text = dgv_verDocentes.Rows[0].Cells[7].Value.ToString();
            txt_emailModDoc2.Text = dgv_verDocentes.Rows[0].Cells[8].Value.ToString();
            txt_direccionModDoc2.Text = dgv_verDocentes.Rows[0].Cells[9].Value.ToString();
            cmb_localidadD.Text = dgv_verDocentes.Rows[0].Cells[10].Value.ToString();


        }



        private void btn_ModificarDocente_Click(object sender, EventArgs e)
        {
            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            string FechaNacimientoNuevaDocente = dtp_FechaNacModDoc2.Value.ToString("dd/MM/yyyy");

            string modificarPersona = "UPDATE Persona set Nombre='" + txt_nombreModDoc2.Text + "', Apellido='" + txt_apellidoModDoc2.Text + "', FechaNac='" + FechaNacimientoNuevaDocente + "', Sexo='" + cmb_sexoModDoc2.Text + "', Direccion ='" + txt_direccionModDoc2.Text + "', CodigoPostal =" + Variables.selecLocalidad3 + " WHERE Persona.DNI =" + Variables.RecibirDniDocente + "; ";

            Variables.Orden = new OleDbCommand(modificarPersona, Variables.ConexionConBD);
            Variables.Lector = Variables.Orden.ExecuteReader();

            string modificarDocente = "UPDATE Docente set Legajo =" + txt_legajoModDoc2.Text + ", Mail ='" + txt_emailModDoc2.Text + "', CodCaracterizacion =" + Variables.selecCaracterizacion2 + " WHERE Docente.DNIDocente =" + Variables.RecibirDniDocente + "; ";

            Variables.Orden = new OleDbCommand(modificarDocente, Variables.ConexionConBD);
            Variables.Lector = Variables.Orden.ExecuteReader();

            string modificarTelefono = "UPDATE Telefono set NumTel =" + txt_telefonoModDoc2.Text + " WHERE  Telefono.DniPersona =" + Variables.RecibirDniDocente + "; ";

            Variables.Orden = new OleDbCommand(modificarTelefono, Variables.ConexionConBD);
            Variables.Lector = Variables.Orden.ExecuteReader();

            Variables.ConexionConBD.Close();

            MessageBox.Show("Todo exitoso");
            this.Close();
        }

        private void cmb_localidadD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.selecLocalidad3 = Convert.ToString(cmb_localidadD.SelectedValue);
        }

        

        private void txt_nombreD_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_CaracterizacionModDoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Variables.selecCaracterizacion2 = Convert.ToString(cmb_CaracterizacionModDoc.SelectedValue);
        }
    }
}
