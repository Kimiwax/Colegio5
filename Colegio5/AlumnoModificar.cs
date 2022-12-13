using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using ClaseVariables;
using System.Reflection;
using System.Data.OleDb;
using MetodosColeg;

namespace Colegio5
{
    public partial class AlumnoModificar : Form
    {
        public AlumnoModificar(int dni, string nom, string ape)
        {
            InitializeComponent();
            if (Variables.user2)
            {
                tP_modAlumno.Enabled = false;
                tP_agre.Enabled = false;
                tP_darDeBaja.Enabled = false;
                tabControl1.TabPages.Remove(tP_modAlumno);
                tabControl1.TabPages.Remove(tP_agre);
                tabControl1.TabPages.Remove(tP_darDeBaja);
            }
            Variables.RecibirDniAlumno = dni;
            Variables.RecibirNomAlumno = nom;
            Variables.RecibirApeAlumno = ape;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_crearDoc_Click(object sender, EventArgs e)
        {
            object ObjMiss = System.Reflection.Missing.Value;

            Word.Application ObjWord = new Word.Application();

            string ruta = Application.StartupPath + @"\ModInformeDeAlumno.docx";
            object parametro = ruta;

            object nomA = "nomape";
            object doc = "docente";
            object docA = "dni";
            object dia = "dia";
            object mes = "mes";
            object anio = "anio";
            object texto = "texto";



            Word.Document ObjDoc = ObjWord.Documents.Open(ref parametro,
            ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss,
            ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss,
            ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss);

            DateTime fechaActual = DateTime.Today;

            Word.Range DIA = ObjDoc.Bookmarks.get_Item(ref dia).Range;
            DIA.Text = fechaActual.Day.ToString();

            Word.Range MES = ObjDoc.Bookmarks.get_Item(ref mes).Range;

            System.Globalization.DateTimeFormatInfo dtinfo =
            new System.Globalization.CultureInfo("es-ES", false).DateTimeFormat;
            MES.Text = dtinfo.GetMonthName(fechaActual.Month);

            Word.Range ANIO = ObjDoc.Bookmarks.get_Item(ref anio).Range;

            ANIO.Text = fechaActual.Year.ToString();
            Word.Range NOMAPE = ObjDoc.Bookmarks.get_Item(ref nomA).Range;
            NOMAPE.Text = txt_nomape.Text;

            Word.Range DNI = ObjDoc.Bookmarks.get_Item(ref docA).Range;
            DNI.Text = txt_dni.Text;

            Word.Range DOCENTE = ObjDoc.Bookmarks.get_Item(ref doc).Range;
            DOCENTE.Text = txt_docente.Text;

            Word.Range TEXTO = ObjDoc.Bookmarks.get_Item(ref texto).Range;
            TEXTO.Text = txt_informe.Text;

            object rango1 = DIA;
            object rango2 = MES;
            object rango3 = ANIO;
            object rango4 = NOMAPE;
            object rango5 = DNI;
            object rango6 = DOCENTE;
            object rango7 = TEXTO;

            ObjDoc.Bookmarks.Add("dia", ref rango1);
            ObjDoc.Bookmarks.Add("mes", ref rango2);
            ObjDoc.Bookmarks.Add("anio", ref rango3);
            ObjDoc.Bookmarks.Add("nomape", ref rango4);
            ObjDoc.Bookmarks.Add("dni", ref rango5);
            ObjDoc.Bookmarks.Add("docente", ref rango6);
            ObjDoc.Bookmarks.Add("texto", ref rango7);

            ObjWord.Visible = true;
            this.Close();
        }

        private void carga_cmbCaracterizacion()
        {
            string consulta2 = "Select CodCaracterizacion, Especificacion from Caracterizacion;";
            Variables.Lector = Metodos.LecturaDB(consulta2);
            DataTable dsCombo2 = new DataTable();
            dsCombo2.Load(Variables.Lector);
            cmb_caracterizacionAMod.DataSource = dsCombo2;
            cmb_caracterizacionAMod.DisplayMember = "Especificacion";
            cmb_caracterizacionAMod.ValueMember = "CodCaracterizacion";
            Variables.Lector.Close();
        }

        private void carga_cmbLocalidad()
        {
            string consulta3 = "Select CP, NomLocalidad from Localidad;";
            Variables.Lector = Metodos.LecturaDB(consulta3);
            DataTable dsCombo = new DataTable();//Creo el objeto de tipo datatable para que reciba los registros del lector
            dsCombo.Load(Variables.Lector);
            cmb_localidadAMod.DataSource = dsCombo;
            cmb_localidadAMod.DisplayMember = "NomLocalidad";//Muestro el nombre de localidad al usuario
            cmb_localidadAMod.ValueMember = "CP";//Tomo el valor de codigo postal de la localidad
            Variables.Lector.Close();
        }

        private void carga_SedeInclusion()
        {
            string consulta3 = "Select CodSedIncDom, Detalle from SedIncDom;";
            Variables.Lector = Metodos.LecturaDB(consulta3);
            DataTable dsCombo = new DataTable();
            dsCombo.Load(Variables.Lector);
            cmb_sedeinclusionAMod.DataSource = dsCombo;
            cmb_sedeinclusionAMod.DisplayMember = "Detalle";
            cmb_sedeinclusionAMod.ValueMember = "CodSedIncDom";
            Variables.Lector.Close();
        }



        private void AlumnoModificar_Load(object sender, EventArgs e)
        {
            Metodos.ConectaDB();

            string ConsultaAlumno = "SELECT Persona.Nombre, Persona.Apellido, Persona.FechaNac, Persona.Sexo, Persona.DNI, Caracterizacion.Especificacion, Alumno.FechaIng, Alumno.ObraSocial, Alumno.CUD, Localidad.NomLocalidad, Persona.Direccion, SedIncDom.Detalle" +
                                    " FROM Caracterizacion INNER JOIN((SedIncDom INNER JOIN(Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) ON SedIncDom.CodSedIncDom = Alumno.CodigoSedIncDom) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones" +
                                    " WHERE Persona.DNI = " + Variables.RecibirDniAlumno + ";";

            Metodos.CargaDB(ConsultaAlumno);

            while (Variables.Lector.Read())
            {

                dgv_Alumnos.Rows.Add();
                dgv_Alumnos[0, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["Nombre"];
                dgv_Alumnos[1, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["Apellido"];
                dgv_Alumnos[2, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["FechaNac"];
                dgv_Alumnos[3, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["Sexo"];
                dgv_Alumnos[4, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["DNI"];
                dgv_Alumnos[5, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["Especificacion"];
                dgv_Alumnos[6, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["FechaIng"];
                dgv_Alumnos[7, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["ObraSocial"];
                dgv_Alumnos[8, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["CUD"];
                dgv_Alumnos[9, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["NomLocalidad"];
                dgv_Alumnos[10, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["Direccion"];
                dgv_Alumnos[11, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["Detalle"];

            }
            dgv_Alumnos.ClearSelection();



            txt_nombreA.Text = dgv_Alumnos.Rows[0].Cells[0].Value.ToString();
            txt_apellidoA.Text = dgv_Alumnos.Rows[0].Cells[1].Value.ToString();
            txt_fecnacA.Text = dgv_Alumnos.Rows[0].Cells[2].Value.ToString().Substring(0, 10);
            txt_sexoA.Text = dgv_Alumnos.Rows[0].Cells[3].Value.ToString();
            txt_dniA.Text = dgv_Alumnos.Rows[0].Cells[4].Value.ToString();
            txt_caracterizacionA.Text = dgv_Alumnos.Rows[0].Cells[5].Value.ToString();
            txt_ingresoA.Text = dgv_Alumnos.Rows[0].Cells[6].Value.ToString().Substring(0, 10);
            txt_osA.Text = dgv_Alumnos.Rows[0].Cells[7].Value.ToString();
            txt_pensionA.Text = dgv_Alumnos.Rows[0].Cells[8].Value.ToString();
            txt_localidadA.Text = dgv_Alumnos.Rows[0].Cells[9].Value.ToString();
            txt_domicilioA.Text = dgv_Alumnos.Rows[0].Cells[10].Value.ToString();
            txt_servicioA.Text = dgv_Alumnos.Rows[0].Cells[11].Value.ToString();

            carga_cmbCaracterizacion();
            carga_cmbLocalidad();
            carga_SedeInclusion();

            txt_nombreAMod.Text = txt_nombreA.Text;
            txt_apellidoAMod.Text = txt_apellidoA.Text;
            dtp_fechadenacAMod.Text = txt_fecnacA.Text;
            cmb_sexoAMod.Text = txt_sexoA.Text;
            cmb_caracterizacionAMod.Text = txt_caracterizacionA.Text;
            txt_obrasocialAMod.Text = txt_osA.Text;
            cmb_cudAMod.Text = txt_pensionA.Text;
            cmb_localidadAMod.Text = txt_localidadA.Text;
            txt_domicilioAMod.Text = txt_domicilioA.Text;
            dtp_fechaIngresoAMod.Text = txt_ingresoA.Text;
            cmb_sedeinclusionAMod.Text = txt_servicioA.Text;

            txt_nomBaja.Text = Variables.RecibirNomAlumno;
            txt_apeBaja.Text = Variables.RecibirApeAlumno;
            txt_dniBaja.Text = Variables.RecibirDniAlumno.ToString();
            

            txt_nomape.Text = dgv_Alumnos.Rows[0].Cells[0].Value.ToString() + " " + dgv_Alumnos.Rows[0].Cells[1].Value.ToString(); ;
            txt_dni.Text = dgv_Alumnos.Rows[0].Cells[4].Value.ToString();

            Metodos.CerrarDB();
        }

        private void btn_ModificarAlumno_Click(object sender, EventArgs e)
        {
            Metodos.ConectaDB();

            string FechaNacimientoNuevaAlumno = dtp_fechadenacAMod.Value.ToString("dd/MM/yyyy");
            string FechaIngresoNuevaAlumno = dtp_fechaIngresoAMod.Value.ToString("dd/MM/yyyy");

            string modificarPersona = "UPDATE Persona set Nombre='" + txt_nombreAMod.Text + "', Apellido='" + txt_apellidoAMod.Text + "', FechaNac='" + FechaNacimientoNuevaAlumno + "', Sexo='" + cmb_sexoAMod.Text + "', Direccion ='" + txt_domicilioAMod.Text + "', CodigoPostal =" + Variables.selecLocalidad4 + " WHERE Persona.DNI =" + Variables.RecibirDniAlumno + "; ";
            Variables.Orden = new OleDbCommand(modificarPersona, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            string ModificarAlumno = "UPDATE Alumno set FechaIng='" + FechaIngresoNuevaAlumno + "', CUD='" + cmb_cudAMod.Text + "', CodigoSedIncDom=" + Variables.selecSedeInclusion + ", ObraSocial='" + txt_obrasocialAMod.Text + "' WHERE Alumno.DNIAlumno = " + Variables.RecibirDniAlumno + "; ";
            Variables.Orden = new OleDbCommand(ModificarAlumno, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            string ModificarAlumCarac = "UPDATE AlumnoCaracterizaciones set CodigoCaracterizaciones=" + Variables.selecSedeInclusion + " WHERE  AlumnoCaracterizaciones.dniAlumno =" + Variables.RecibirDniDocente + "; ";

            Variables.Orden = new OleDbCommand(ModificarAlumCarac, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            Metodos.CerrarDB2();

            MessageBox.Show("Se actualizaron correctamente los registros");
            this.Close();
        }

        private void cmb_localidadAMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.selecLocalidad4 = Convert.ToString(cmb_localidadAMod.SelectedValue);
        }

        private void cmb_sedeinclusionAMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.selecSedeInclusion = Convert.ToString(cmb_sedeinclusionAMod.SelectedValue);
        }

        private void cmb_caracterizacionAMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.selecCaracterizacion = Convert.ToString(cmb_caracterizacionAMod.SelectedValue);
        }

        private void btn_eliminarAlumno_Click(object sender, EventArgs e)
        {
            Metodos.ConectaDB();

            string BajaAlumno = "UPDATE Alumno set Habilitado=" + 0 + " WHERE Alumno.DNIAlumno = " + Variables.RecibirDniAlumno + "; ";

            Variables.Orden = new OleDbCommand(BajaAlumno, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            MessageBox.Show("Se Deshabilito al alumno correctamente");

            Metodos.CerrarDB2();
            

            this.Close();
        }

        private void btn_habilitarAlumno_Click(object sender, EventArgs e)
        {
            Metodos.ConectaDB();

            string BajaAlumno = "UPDATE Alumno set Habilitado=" + 1 + " WHERE Alumno.DNIAlumno = " + Variables.RecibirDniAlumno + "; ";

            Variables.Orden = new OleDbCommand(BajaAlumno, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();

            MessageBox.Show("Se Habilito al alumno correctamente");

            Metodos.CerrarDB2();

            
            this.Close();
        }
    }
}
