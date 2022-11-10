using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetodosColeg;
using System.Text.RegularExpressions;
using ClaseVariables;
using System.Data.OleDb;


namespace Colegio5
{
    public partial class AlumnoAgregarAdulto : Form
    {
        public AlumnoAgregarAdulto(string dniAlumno)
        {
            InitializeComponent();
            Variables.DNIAlumno = dniAlumno;
        }

        
        public static OleDbDataReader LecturaDB(string consulta)
        {
            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            Variables.Orden = new OleDbCommand(consulta, Variables.ConexionConBD);
            Variables.Lector = Variables.Orden.ExecuteReader();
            return Variables.Lector;

            Variables.ConexionConBD.Close();

        }


        private bool IsValidate()
        {
            bool noError = true;
            //VerificarFechaDeNac();
            if (string.IsNullOrEmpty(txt_nombreAdul.Text))
            {
                errorProviderAdul.SetError(txt_nombreAdul, "Ingrese NOMBRE del Tutor ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_apellidoAdul.Text))
            {
                errorProviderAdul.Clear();
                errorProviderAdul.SetError(txt_apellidoAdul, "Ingrese APELLIDO del Tutor ");
                noError = false;
            }
            else if (DateTime.Now.Subtract(dtp_fenacAdul.Value.Date).Days < 10)
            {
                errorProviderAdul.Clear();
                errorProviderAdul.SetError(dtp_fenacAdul, "Ingrese una fecha correcta ");
                noError = false;
            }
            else if (cmb_sexoAdul.SelectedIndex == -1)
            {
                errorProviderAdul.Clear();
                errorProviderAdul.SetError(cmb_sexoAdul, "Seleccione SEXO del Tutor ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_dniAdul.Text))
            {
                errorProviderAdul.Clear();
                errorProviderAdul.SetError(txt_dniAdul, "Ingrese DNI del Tutor ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_ocupacionAdul.Text))
            {
                errorProviderAdul.Clear();
                errorProviderAdul.SetError(txt_ocupacionAdul, "Ingrese OCUPACIÓN del Tutor ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_emailAdul.Text))
            {
                errorProviderAdul.Clear();
                errorProviderAdul.SetError(txt_emailAdul, "Ingrese Correo Electronico del Tutor");
                noError = false;
            }
            else if (cmb_permanenteAdul.SelectedIndex == -1)
            {
                errorProviderAdul.Clear();
                errorProviderAdul.SetError(cmb_permanenteAdul, "Seleccione si el Tutor es Permanente");
                noError = false;
            }
            else if (cmb_localidadAdul.SelectedIndex == -1)
            {
                errorProviderAdul.Clear();
                errorProviderAdul.SetError(cmb_localidadAdul, "Ingrese LOCALIDAD del Tutor ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_domicilioAdul.Text))
            {
                errorProviderAdul.Clear();
                errorProviderAdul.SetError(txt_domicilioAdul, "Ingrese DOMICILIO del Tutor ");
                noError = false;
            }
            else if (string.IsNullOrEmpty(txt_telefonoAdul.Text))
            {
                errorProviderAdul.Clear();
                errorProviderAdul.SetError(txt_telefonoAdul, "Ingrese un TELÉFONO del Tutor");
                noError = false;
            }
            else if (cmb_Parentesco1.SelectedIndex == -1)
            {
                errorProviderAdul.Clear();
                errorProviderAdul.SetError(cmb_Parentesco1, "Ingrese PARENTESCO del Tutor ");
                noError = false;
            }
            
            if(chk_otroAdulto.Checked == true)
            {
                if (string.IsNullOrEmpty(txt_nombreAdul2.Text))
                {
                    errorProviderAdul.SetError(txt_nombreAdul2, "Ingrese NOMBRE del Tutor ");
                    noError = false;
                }
                else if (string.IsNullOrEmpty(txt_apellidoAdul2.Text))
                {
                    errorProviderAdul.Clear();
                    errorProviderAdul.SetError(txt_apellidoAdul2, "Ingrese APELLIDO del Tutor ");
                    noError = false;
                }
                else if (DateTime.Now.Subtract(dtp_fenacAdul2.Value.Date).Days < 10)
                {
                    errorProviderAdul.Clear();
                    errorProviderAdul.SetError(dtp_fenacAdul2, "Ingrese una fecha correcta ");
                    noError = false;
                }
                else if (cmb_sexoAdul2.SelectedIndex == -1)
                {
                    errorProviderAdul.Clear();
                    errorProviderAdul.SetError(cmb_sexoAdul2, "Seleccione SEXO del Tutor ");
                    noError = false;
                }
                else if (string.IsNullOrEmpty(txt_dniAdul2.Text))
                {
                    errorProviderAdul.Clear();
                    errorProviderAdul.SetError(txt_dniAdul2, "Ingrese DNI del Tutor ");
                    noError = false;
                }
                else if (string.IsNullOrEmpty(txt_ocupacionAdul2.Text))
                {
                    errorProviderAdul.Clear();
                    errorProviderAdul.SetError(txt_ocupacionAdul2, "Ingrese OCUPACIÓN del Tutor ");
                    noError = false;
                }
                else if (string.IsNullOrEmpty(txt_emailAdul2.Text))
                {
                    errorProviderAdul.Clear();
                    errorProviderAdul.SetError(txt_emailAdul2, "Ingrese Correo Electronico del Tutor");
                    noError = false;
                }
                else if (cmb_permanenteAdul2.SelectedIndex == -1)
                {
                    errorProviderAdul.Clear();
                    errorProviderAdul.SetError(cmb_permanenteAdul2, "Seleccione si el Tutor es Permanente");
                    noError = false;
                }
                else if (cmb_localidadAdul2.SelectedIndex == -1)
                {
                    errorProviderAdul.Clear();
                    errorProviderAdul.SetError(cmb_localidadAdul2, "Ingrese LOCALIDAD del Tutor ");
                    noError = false;
                }
                else if (string.IsNullOrEmpty(txt_domicioAdul2.Text))
                {
                    errorProviderAdul.Clear();
                    errorProviderAdul.SetError(txt_domicioAdul2, "Ingrese DOMICILIO del Tutor ");
                    noError = false;
                }
                else if (string.IsNullOrEmpty(txt_telefonoAdul2.Text))
                {
                    errorProviderAdul.Clear();
                    errorProviderAdul.SetError(txt_telefonoAdul2, "Ingrese un TELÉFONO del Tutor");
                    noError = false;
                }
                else if (cmb_Parentesco2.SelectedIndex == -1)
                {
                    errorProviderAdul.Clear();
                    errorProviderAdul.SetError(cmb_Parentesco1, "Ingrese PARENTESCO del Tutor ");
                    noError = false;
                }
            }

            return noError;
        }

        private void carga_cmbLocalidad()
        {
            string consulta3 = "Select CP, NomLocalidad from Localidad;";
            Variables.Lector = LecturaDB(consulta3);
            DataTable dsCombo = new DataTable();//Creo el objeto de tipo datatable para que reciba los registros del lector
            dsCombo.Load(Variables.Lector);
            cmb_localidadAdul.DataSource = dsCombo;
            cmb_localidadAdul.DisplayMember = "NomLocalidad";//Muestro el nombre de localidad al usuario
            cmb_localidadAdul.ValueMember = "CP";//Tomo el valor de codigo postal de la localidad
            Variables.Lector.Close();
        }

        private void carga_cmbLocalidad2()
        {
            string consulta3 = "Select CP, NomLocalidad from Localidad;";
            Variables.Lector = LecturaDB(consulta3);
            DataTable dsCombo = new DataTable();//Creo el objeto de tipo datatable para que reciba los registros del lector
            dsCombo.Load(Variables.Lector);
            cmb_localidadAdul2.DataSource = dsCombo;
            cmb_localidadAdul2.DisplayMember = "NomLocalidad";//Muestro el nombre de localidad al usuario
            cmb_localidadAdul2.ValueMember = "CP";//Tomo el valor de codigo postal de la localidad
            Variables.Lector.Close();
        }

        private void carga_cmbParentesco()
        {
            string consulta3 = "Select CodParentesco, Descripcion from Parentesco;";
            Variables.Lector = LecturaDB(consulta3);
            DataTable dsCombo = new DataTable();
            dsCombo.Load(Variables.Lector);
            cmb_Parentesco1.DataSource = dsCombo;
            cmb_Parentesco1.DisplayMember = "Descripcion";
            cmb_Parentesco1.ValueMember = "CodParentesco";
            Variables.Lector.Close();
            
        }

        private void carga_cmbParentesco2()
        {
            string consulta3 = "Select CodParentesco, Descripcion from Parentesco;";
            Variables.Lector = LecturaDB(consulta3);
            DataTable dsCombo = new DataTable();
            dsCombo.Load(Variables.Lector);
            cmb_Parentesco2.DataSource = dsCombo;
            cmb_Parentesco2.DisplayMember = "Descripcion";
            cmb_Parentesco2.ValueMember = "CodParentesco";
            Variables.Lector.Close();

        }




        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Está seguro de que quiere agregar este alumno?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(res == DialogResult.Yes)
            {
                if (IsValidate())
                {
                    errorProviderAdul.Clear();
                    Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                    Variables.ConexionConBD.Open();

                    string FechaNacimientoAdulto = dtp_fenacAdul.Value.ToString("dd/MM/yyyy");
                    string FechaNacimientoAdulto2 = dtp_fenacAdul2.Value.ToString("dd/MM/yyyy");

                    //string insertPersonaAdulto = "INSERT INTO Persona (DNI, Nombre, Apellido, FechaNac, Sexo, Direccion, CodigoPostal) Values (" + txt_dniAdul.Text + ",'" + txt_nombreAdul.Text + "','" + txt_apellidoAdul.Text + "','" + FechaNacimientoAdulto + "','" + cmb_sexoAdul.Text + "','" + txt_domicilioAdul.Text + "'," + Variables.selecLocalidad + ");";
                    //string insertTelAdulto = "INSERT INTO Telefono(DniPersona, NumTel) values (" + txt_dniAdul.Text + "," + txt_telefonoAdul.Text + ");";
                    //string insertResponsable = "INSERT INTO Responsable (DNIResponsable, CodigoParentesco, Mail, Ocupacion, Permanente) Values (" + txt_dniAdul.Text + "," + Variables.selecParentesco + ",'" + txt_emailAdul.Text + "','" + txt_ocupacionAdul.Text + "','" + cmb_permanenteAdul.Text + "');";
                    //string insertResAlumno = "INSERT INTO RepresentanteAlumno(DNIAlumn, DNIRepresentante) Values (" + Variables.DNIAlumno + "," + txt_dniAdul.Text + ");";

                    if (chk_otroAdulto.Checked == true)
                    {
                        string insertPersonaAdulto = "INSERT INTO Persona (DNI, Nombre, Apellido, FechaNac, Sexo, Direccion, CodigoPostal) Values (" + txt_dniAdul.Text + ",'" + txt_nombreAdul.Text + "','" + txt_apellidoAdul.Text + "','" + FechaNacimientoAdulto + "','" + cmb_sexoAdul.Text + "','" + txt_domicilioAdul.Text + "'," + Variables.selecLocalidad + ");";
                        string insertTelAdulto = "INSERT INTO Telefono(DniPersona, NumTel) values (" + txt_dniAdul.Text + "," + txt_telefonoAdul.Text + ");";
                        string insertResponsable = "INSERT INTO Responsable (DNIResponsable, CodigoParentesco, Mail, Ocupacion, Permanente) Values (" + txt_dniAdul.Text + "," + Variables.selecParentesco + ",'" + txt_emailAdul.Text + "','" + txt_ocupacionAdul.Text + "','" + cmb_permanenteAdul.Text + "');";
                        string insertResAlumno = "INSERT INTO RepresentanteAlumno(DNIAlumn, DNIRepresentante) Values (" + Variables.DNIAlumno + "," + txt_dniAdul.Text + ");";

                        string insertPersonaAdulto2 = "INSERT INTO Persona (DNI, Nombre, Apellido, FechaNac, Sexo, Direccion, CodigoPostal) Values (" + txt_dniAdul2.Text + ",'" + txt_nombreAdul2.Text + "','" + txt_apellidoAdul2.Text + "','" + FechaNacimientoAdulto2 + "','" + cmb_sexoAdul2.Text + "','" + txt_domicioAdul2.Text + "'," + Variables.selecLocalidad2 + ");";
                        string insertTelAdulto2 = "INSERT INTO Telefono(DniPersona, NumTel) values (" + txt_dniAdul2.Text + "," + txt_telefonoAdul2.Text + ");";
                        string insertResponsable2 = "INSERT INTO Responsable (DNIResponsable, CodigoParentesco, Mail, Ocupacion, Permanente) Values (" + txt_dniAdul2.Text + "," + Variables.selecParentesco2 + ",'" + txt_emailAdul2.Text + "','" + txt_ocupacionAdul2.Text + "','" + cmb_permanenteAdul2.Text + "');";
                        string insertResAlumno2 = "INSERT INTO RepresentanteAlumno(DNIAlumn, DNIRepresentante) Values (" + Variables.DNIAlumno + "," + txt_dniAdul2.Text + ");";

                        Variables.Orden = new OleDbCommand(insertPersonaAdulto, Variables.ConexionConBD);
                        Variables.Orden.ExecuteNonQuery();

                        Variables.Orden = new OleDbCommand(insertTelAdulto, Variables.ConexionConBD);
                        Variables.Orden.ExecuteNonQuery();

                        Variables.Orden = new OleDbCommand(insertResponsable, Variables.ConexionConBD);
                        Variables.Orden.ExecuteNonQuery();

                        Variables.Orden = new OleDbCommand(insertResAlumno, Variables.ConexionConBD);
                        Variables.Orden.ExecuteNonQuery();


                        Variables.Orden = new OleDbCommand(insertPersonaAdulto2, Variables.ConexionConBD);
                        Variables.Orden.ExecuteNonQuery();

                        Variables.Orden = new OleDbCommand(insertTelAdulto2, Variables.ConexionConBD);
                        Variables.Orden.ExecuteNonQuery();

                        Variables.Orden = new OleDbCommand(insertResponsable2, Variables.ConexionConBD);
                        Variables.Orden.ExecuteNonQuery();

                        Variables.Orden = new OleDbCommand(insertResAlumno2, Variables.ConexionConBD);
                        Variables.Orden.ExecuteNonQuery();

                    }
                    else if (chk_otroAdulto.Checked == false)
                    {
                        string insertPersonaAdulto = "INSERT INTO Persona (DNI, Nombre, Apellido, FechaNac, Sexo, Direccion, CodigoPostal) Values (" + txt_dniAdul.Text + ",'" + txt_nombreAdul.Text + "','" + txt_apellidoAdul.Text + "','" + FechaNacimientoAdulto + "','" + cmb_sexoAdul.Text + "','" + txt_domicilioAdul.Text + "'," + Variables.selecLocalidad + ");";
                        string insertTelAdulto = "INSERT INTO Telefono(DniPersona, NumTel) values (" + txt_dniAdul.Text + "," + txt_telefonoAdul.Text + ");";
                        string insertResponsable = "INSERT INTO Responsable (DNIResponsable, CodigoParentesco, Mail, Ocupacion, Permanente) Values (" + txt_dniAdul.Text + "," + Variables.selecParentesco + ",'" + txt_emailAdul.Text + "','" + txt_ocupacionAdul.Text + "','" + cmb_permanenteAdul.Text + "');";
                        string insertResAlumno = "INSERT INTO RepresentanteAlumno(DNIAlumn, DNIRepresentante) Values (" + Variables.DNIAlumno + "," + txt_dniAdul.Text + ");";

                        Variables.Orden = new OleDbCommand(insertPersonaAdulto, Variables.ConexionConBD);
                        Variables.Orden.ExecuteNonQuery();

                        Variables.Orden = new OleDbCommand(insertTelAdulto, Variables.ConexionConBD);
                        Variables.Orden.ExecuteNonQuery();

                        Variables.Orden = new OleDbCommand(insertResponsable, Variables.ConexionConBD);
                        Variables.Orden.ExecuteNonQuery();

                        Variables.Orden = new OleDbCommand(insertResAlumno, Variables.ConexionConBD);
                        Variables.Orden.ExecuteNonQuery();
                    }

                    //string insertPersonaAdulto2 = "INSERT INTO Persona (DNI, Nombre, Apellido, FechaNac, Sexo, Direccion, CodigoPostal) Values (" + txt_dniAdul2.Text + ",'" + txt_nombreAdul2.Text + "','" + txt_apellidoAdul2.Text + "','" + FechaNacimientoAdulto2 + "','" + cmb_sexoAdul2.Text + "','" + txt_domicioAdul2.Text + "'," + Variables.selecLocalidad2 + ");";
                    //string insertTelAdulto2 = "INSERT INTO Telefono(DniPersona, NumTel) values (" + txt_dniAdul2.Text + "," + txt_telefonoAdul2.Text + ");";
                    //string insertResponsable2 = "INSERT INTO Responsable (DNIResponsable, CodigoParentesco, Mail, Ocupacion, Permanente) Values (" + txt_dniAdul2.Text + "," + Variables.selecParentesco2 + ",'" + txt_emailAdul2.Text + "','" + txt_ocupacionAdul2.Text + "','" + cmb_permanenteAdul2.Text + "');";
                    //string insertResAlumno2 = "INSERT INTO RepresentanteAlumno(DNIAlumn, DNIRepresentante) Values (" + Variables.DNIAlumno + "," + txt_dniAdul2.Text + ");";

                    //Variables.Orden = new OleDbCommand(insertPersonaAdulto, Variables.ConexionConBD);
                    //Variables.Orden.ExecuteNonQuery();

                    //Variables.Orden = new OleDbCommand(insertTelAdulto, Variables.ConexionConBD);
                    //Variables.Orden.ExecuteNonQuery();

                    //Variables.Orden = new OleDbCommand(insertResponsable, Variables.ConexionConBD);
                    //Variables.Orden.ExecuteNonQuery();

                    //Variables.Orden = new OleDbCommand(insertResAlumno, Variables.ConexionConBD);
                    //Variables.Orden.ExecuteNonQuery();


                    //Variables.Orden = new OleDbCommand(insertPersonaAdulto2, Variables.ConexionConBD);
                    //Variables.Orden.ExecuteNonQuery();

                    //Variables.Orden = new OleDbCommand(insertTelAdulto2, Variables.ConexionConBD);
                    //Variables.Orden.ExecuteNonQuery();

                    //Variables.Orden = new OleDbCommand(insertResponsable2, Variables.ConexionConBD);
                    //Variables.Orden.ExecuteNonQuery();

                    //Variables.Orden = new OleDbCommand(insertResAlumno2, Variables.ConexionConBD);
                    //Variables.Orden.ExecuteNonQuery();

                    Variables.ConexionConBD.Close();

                    MessageBox.Show("EL ALUMNO Y SUS RESPECTIVOS TUTORES FUERON AGREGADO CON ÉXITO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {

            }

            
        }
        




        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombreAdul_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(e);
        }

        private void txt_apellidoAdul_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(e);
        }

        private void txt_dniAdul_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNumeros(e);
        }

        private void txt_ocupacionAdul_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(e);
        }

        private void txt_emailAdul_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.Validaremail(e);
        }

        private void txt_localidadAdul_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarSoloNumerosYLetras(e);
        }

        private void txt_domicilioAdul_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarSoloNumerosYLetras(e);
        }

        private void txt_telefonoAdul_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNumeros(e);
        }

        private void txt_telefono2Adul_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNumeros(e);
        }

        private void txt_parentescoAdul_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_localidadAdul_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.selecLocalidad = Convert.ToString(cmb_localidadAdul.SelectedValue);
        }

        private void cmb_Parentesco1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.selecParentesco = Convert.ToString(cmb_Parentesco1.SelectedValue);
        }

        private void cmb_localidadAdul2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.selecLocalidad2 = Convert.ToString(cmb_localidadAdul2.SelectedValue);
        }

        private void cmb_Parentesco2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.selecParentesco2 = Convert.ToString(cmb_Parentesco2.SelectedValue);
        }

        private void AlumnoAgregarAdulto_Load(object sender, EventArgs e)
        {
            carga_cmbLocalidad();
            carga_cmbLocalidad2();
            carga_cmbParentesco();
            carga_cmbParentesco2();
        }

        private void chk_otroAdulto_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_otroAdulto.Checked == true)
            {
                panel2.Enabled = true;
            }
            else
            {
                chk_otroAdulto.Checked = false;
                panel2.Enabled = false;
            }
        }

        private void txt_nombreAdul2_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodosColeg.Metodos.ValidarLetras(e);
        }

        private void txt_apellidoAdul2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(e);
        }

        private void txt_dniAdul2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNumeros(e);
        }

        private void txt_ocupacionAdul2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarLetras(e);
        }

        private void txt_emailAdul2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.Validaremail(e);
        }

        private void txt_domicioAdul2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarSoloNumerosYLetras(e);
        }

        private void txt_telefonoAdul2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNumeros(e);
        }

        private void txt_telefono2Adul2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNumeros(e);
        }
    }
}
