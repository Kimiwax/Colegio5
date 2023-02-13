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
using System.Drawing.Printing;
using DGVPrinterHelper;




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
            if (txt_buscarDni.Text != "")
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
            if (e.RowIndex == (-1))
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
            if (e.RowIndex == (-1))
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
                panelContenedorCaracterizaciones.Enabled = false;
                panelContenedorCaracterizaciones.Visible = false;
                rb_caracterizacion2.Checked = false;
                rb_caracterizacion3.Checked = false;
                rb_caracterizacion4.Checked = false;
                rb_caracterizacion5.Checked = false;
                rb_caracterizacion6.Checked = false;
                rb_caracterizacion9.Checked = false;

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
            else if (cmb_filtros.Text == "Caracterización")
            {
                panelContenedorCaracterizaciones.Enabled = true;
                panelContenedorCaracterizaciones.Visible = true;

                panelContenedorServicio.Enabled = false;
                panelContenedorServicio.Visible = false;
            }
            else if (cmb_filtros.Text == "Servicios")
            {
                panelContenedorServicio.Enabled = true;
                panelContenedorServicio.Visible = true;

                panelContenedorCaracterizaciones.Enabled = false;
                panelContenedorCaracterizaciones.Visible = false;
            }
            else if (cmb_filtros.Text == "Todos")
            {
                panelContenedorCaracterizaciones.Enabled = false;
                panelContenedorCaracterizaciones.Visible = false;
                panelContenedorServicio.Enabled = false;
                panelContenedorServicio.Visible = false;
                rb_caracterizacion2.Checked = false;
                rb_caracterizacion3.Checked = false;
                rb_caracterizacion4.Checked = false;
                rb_caracterizacion5.Checked = false;
                rb_caracterizacion6.Checked = false;
                rb_caracterizacion9.Checked = false;
                Cargar_Grilla();
            }
            else if (cmb_filtros.Text == "Servicio")
            {

            }

        }



        private void rb_caracterizacion2_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_filtros.Text == "Caracterización" && rb_caracterizacion2.Checked == true)
            {
                dgv_alumnos.DataSource = null;
                dgv_alumnos.Rows.Clear();

                Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                Variables.ConexionConBD.Open();

                string consulta2 = "SELECT Alumno.DNIAlumno, Persona.Nombre, Persona.Apellido, Caracterizacion.Especificacion, Localidad.NomLocalidad, Persona.Direccion" +
                                       " FROM Caracterizacion INNER JOIN((Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones" +
                                       " WHERE AlumnoCaracterizaciones.CodigoCaracterizaciones = " + 2 + ";";



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
        }

        private void rb_caracterizacion3_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_filtros.Text == "Caracterización" && rb_caracterizacion3.Checked == true)
            {
                dgv_alumnos.DataSource = null;
                dgv_alumnos.Rows.Clear();

                Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                Variables.ConexionConBD.Open();

                string consulta2 = "SELECT Alumno.DNIAlumno, Persona.Nombre, Persona.Apellido, Caracterizacion.Especificacion, Localidad.NomLocalidad, Persona.Direccion" +
                                       " FROM Caracterizacion INNER JOIN((Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones" +
                                       " WHERE AlumnoCaracterizaciones.CodigoCaracterizaciones = " + 3 + ";";



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
        }

        private void rb_caracterizacion4_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_filtros.Text == "Caracterización" && rb_caracterizacion4.Checked == true)
            {
                dgv_alumnos.DataSource = null;
                dgv_alumnos.Rows.Clear();

                Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                Variables.ConexionConBD.Open();

                string consulta2 = "SELECT Alumno.DNIAlumno, Persona.Nombre, Persona.Apellido, Caracterizacion.Especificacion, Localidad.NomLocalidad, Persona.Direccion" +
                                       " FROM Caracterizacion INNER JOIN((Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones" +
                                       " WHERE AlumnoCaracterizaciones.CodigoCaracterizaciones = " + 4 + ";";



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
        }

        private void rb_caracterizacion5_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_filtros.Text == "Caracterización" && rb_caracterizacion5.Checked == true)
            {
                dgv_alumnos.DataSource = null;
                dgv_alumnos.Rows.Clear();

                Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                Variables.ConexionConBD.Open();

                string consulta2 = "SELECT Alumno.DNIAlumno, Persona.Nombre, Persona.Apellido, Caracterizacion.Especificacion, Localidad.NomLocalidad, Persona.Direccion" +
                                       " FROM Caracterizacion INNER JOIN((Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones" +
                                       " WHERE AlumnoCaracterizaciones.CodigoCaracterizaciones = " + 5 + ";";



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
        }

        private void rb_caracterizacion6_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_filtros.Text == "Caracterización" && rb_caracterizacion6.Checked == true)
            {
                dgv_alumnos.DataSource = null;
                dgv_alumnos.Rows.Clear();

                Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                Variables.ConexionConBD.Open();

                string consulta2 = "SELECT Alumno.DNIAlumno, Persona.Nombre, Persona.Apellido, Caracterizacion.Especificacion, Localidad.NomLocalidad, Persona.Direccion" +
                                       " FROM Caracterizacion INNER JOIN((Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones" +
                                       " WHERE AlumnoCaracterizaciones.CodigoCaracterizaciones = " + 6 + ";";



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
        }

        private void rb_caracterizacion9_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_filtros.Text == "Caracterización" && rb_caracterizacion9.Checked == true)
            {
                dgv_alumnos.DataSource = null;
                dgv_alumnos.Rows.Clear();

                Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                Variables.ConexionConBD.Open();

                string consulta2 = "SELECT Alumno.DNIAlumno, Persona.Nombre, Persona.Apellido, Caracterizacion.Especificacion, Localidad.NomLocalidad, Persona.Direccion" +
                                       " FROM Caracterizacion INNER JOIN((Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones" +
                                       " WHERE AlumnoCaracterizaciones.CodigoCaracterizaciones = " + 9 + ";";



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
        }

        private void txt_buscarDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarNumeros(e);
        }

        private void txt_buscarDni_Enter(object sender, EventArgs e)
        {
            txt_buscarDni.Text = "";
        }

        private void txt_buscarDni_Leave(object sender, EventArgs e)
        {
            if (txt_buscarDni.Text == "")
            {
                dgv_alumnos.Rows.Clear();
                Cargar_Grilla();
            }
        }

        private void cmb_filtros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rb_sede_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_filtros.Text == "Servicios" && rb_sede.Checked == true)
            {
                dgv_alumnos.DataSource = null;
                dgv_alumnos.Rows.Clear();

                Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                Variables.ConexionConBD.Open();

                string consulta2 = "SELECT Alumno.DNIAlumno, Persona.Nombre, Persona.Apellido, Caracterizacion.Especificacion, Localidad.NomLocalidad, Persona.Direccion" +
                                       " FROM Caracterizacion INNER JOIN((Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones" +
                                       " WHERE  Alumno.CodigoSedIncDom = " + 2 + ";";



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
        }

        private void rb_inc_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_filtros.Text == "Servicios" && rb_inc.Checked == true)
            {
                dgv_alumnos.DataSource = null;
                dgv_alumnos.Rows.Clear();

                Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
                Variables.ConexionConBD.Open();

                string consulta2 = "SELECT Alumno.DNIAlumno, Persona.Nombre, Persona.Apellido, Caracterizacion.Especificacion, Localidad.NomLocalidad, Persona.Direccion" +
                                       " FROM Caracterizacion INNER JOIN((Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones" +
                                       " WHERE  Alumno.CodigoSedIncDom = " + 3 + ";";



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
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
          

            if (rb_sede.Checked)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Alumnos en Sede";
                printer.SubTitle = DateTime.Now.Date.ToString("MM/dd/yyyy").ToString();
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PageSettings.Landscape = true;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "SaxtonHale";
                printer.FooterSpacing = 15;
                dgv_alumnos.DefaultCellStyle.BackColor = Color.White;
                dgv_alumnos.ForeColor = Color.Black;
                dgv_alumnos.Visible = false;
                printer.PrintDataGridView(dgv_alumnos);
                dgv_alumnos.DefaultCellStyle.BackColor = Color.FromArgb(33, 39, 52);
                dgv_alumnos.ForeColor = Color.White;
                dgv_alumnos.Visible = true;
            }
            else if(rb_inc.Checked){
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Alumnos en Inclusión";
                printer.SubTitle = DateTime.Now.Date.ToString("MM/dd/yyyy").ToString();
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PageSettings.Landscape = true;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "SaxtonHale";
                printer.FooterSpacing = 15;
                dgv_alumnos.DefaultCellStyle.BackColor = Color.White;
                dgv_alumnos.ForeColor = Color.Black;
                dgv_alumnos.Visible = false;
                printer.PrintDataGridView(dgv_alumnos);
                dgv_alumnos.DefaultCellStyle.BackColor = Color.FromArgb(33, 39, 52);
                dgv_alumnos.ForeColor = Color.White;
                dgv_alumnos.Visible = true;
            }
            else if (rb_caracterizacion2.Checked)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Alumnos Sordos Hipoacusicos";
                printer.SubTitle = DateTime.Now.Date.ToString("MM/dd/yyyy").ToString();
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PageSettings.Landscape = true;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "SaxtonHale";
                printer.FooterSpacing = 15;
                dgv_alumnos.DefaultCellStyle.BackColor = Color.White;
                dgv_alumnos.ForeColor = Color.Black;
                dgv_alumnos.Visible = false;
                printer.PrintDataGridView(dgv_alumnos);
                dgv_alumnos.DefaultCellStyle.BackColor = Color.FromArgb(33, 39, 52);
                dgv_alumnos.ForeColor = Color.White;
                dgv_alumnos.Visible = true;
            }
            else
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Todos los Alumnos";
                printer.SubTitle = DateTime.Now.Date.ToString("MM/dd/yyyy").ToString();
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PageSettings.Landscape = true;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "SaxtonHale";
                printer.FooterSpacing = 15;
                dgv_alumnos.DefaultCellStyle.BackColor = Color.White;
                dgv_alumnos.ForeColor = Color.Black;
                dgv_alumnos.Visible = false;
                printer.PrintDataGridView(dgv_alumnos);
                dgv_alumnos.DefaultCellStyle.BackColor = Color.FromArgb(33, 39, 52);
                dgv_alumnos.ForeColor = Color.White;
                dgv_alumnos.Visible = true;
            }

        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {

        }
    }
}
